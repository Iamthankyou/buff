USE BT2
/*=========================================================BAI1===========================================================*/
/*
1. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update bản ghi để chỉ cho
phép nhập giá trị trong khoảng từ 0 đến 10
*/

DROP TRIGGER ruleDiem

CREATE TRIGGER ruleDiem ON DIEM FOR UPDATE,INSERT AS
BEGIN
	DECLARE @toan float, @ly float, @hoa float, @van float
	SELECT @toan=TOAN,@ly=LY,@hoa=HOA,@van=VAN FROM INSERTED

	IF @toan<0 OR @toan>10 OR @ly<0 OR @ly>10 OR @hoa<0 OR @hoa>10 OR @van<0 OR @van>10
		ROLLBACK TRAN
END

-- Check

SELECT * FROM DIEM

UPDATE DIEM SET TOAN = 3 WHERE MAHS LIKE '00001'


/*
2. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động cập nhật
điểm trung bình của học sinh khi thêm mới hay cập nhật bảng điểm
Điểm trung bình= ((Toán +Văn)*2+Lý+Hóa)/6
*/

DROP TRIGGER autoDTB

CREATE TRIGGER autoDTB ON DIEM FOR INSERT,UPDATE AS
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
		RETURN

	UPDATE DIEM SET DTB=ROUND((TOAN*2+VAN*2+LY+Hoa)/6,2) WHERE MAHS = (SELECT MAHS FROM INSERTED)
END

-- Check

SELECT * FROM DIEM 

UPDATE DIEM SET TOAN=10 WHERE MAHS LIKE '00001'

/*
3. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại
học sinh, cách thức xếp loại như sau
- Nếu Điểm trung bình>=5 là lên lớp, ngược lại là lưu ban
*/

-- INIT
ALTER TABLE DSHS ADD XepLoai nvarchar(20)

SELECT * FROM DSHS

-- TRIGGER
CREATE TRIGGER autoRank ON DIEM FOR INSERT,UPDATE AS
BEGIN
	IF TRIGGER_NESTLEVEL()>1
		RETURN

	DECLARE @dtb float, @mahs nvarchar(5)
	SELECT @dtb=(TOAN*2+VAN*2+LY+HOA)/6, @mahs=MAHS FROM INSERTED

	IF @dtb>=5 
		UPDATE DSHS SET XepLoai='Len Lop' WHERE @mahs = MAHS
	ELSE
		UPDATE DSHS SET XepLoai='Luu Ban' WHERE @mahs = MAHS
END

-- Check

SELECT * FROM DSHS
UPDATE DIEM SET TOAN=10 WHERE MAHS LIKE '00001'

/*
4. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại
học sinh, cách thức xếp loại như sau
- Xét điểm thấp nhất (DTN) của các 4 môn
- Nếu DTB>=5 và DTN>=4 là “Lên Lớp”, ngược lại là lưu ban
*/

-- INIT

CREATE FUNCTION min4(@a float, @b float, @c float, @d float) RETURNS float AS
BEGIN
	DECLARE @min float
	SET @min=@a
	
	IF @b<@min
		SET @min=@b
	IF @c<@min
		SET @min=@c
	IF @d<@min
		SET @min=@d

	RETURN @min
END

-- TRIGGER

CREATE TRIGGER autoRank2 ON DIEM FOR INSERT,UPDATE AS
BEGIN
	
	IF TRIGGER_NESTLEVEL()>1
		RETURN

	DECLARE @dtb float, @mahs nvarchar(5), @dtn float
	SELECT @dtb=(TOAN*2+VAN*2+LY+HOA)/6, @mahs=MAHS, @dtn=dbo.min4(TOAN,VAN,LY,HOA) FROM INSERTED

	IF @dtb>=5 AND @dtn>=4
		UPDATE DSHS SET XepLoai='Len Lop' WHERE @mahs = MAHS
	ELSE
		UPDATE DSHS SET XepLoai='Luu Ban' WHERE @mahs = MAHS
END

-- Check
SELECT * FROM DSHS
SELECT * FROM DIEM
UPDATE DIEM SET HOA=10 WHERE MAHS LIKE '00001'

/*
5. Viết một trigger xóa tự động bản ghi về điểm học sinh khi xóa dữ liệu học sinh đó trong
DSHS
*/

-- INIT

SELECT * FROM sys.triggers

DROP TRIGGER diemThapNhat
DROP TRIGGER autoUpdate2
DROP TRIGGER tgDiem
DROP TRIGGER autoDTB
DROP TRIGGER autoRank
DROP TRIGGER autoRank2
DROP TRIGGER autoDelete1


-- Trigger

DROP TRIGGER autoDelete1

CREATE TRIGGER autoDelete1 ON DSHS FOR DELETE AS
BEGIN
	IF TRIGGER_NESTLEVEL()>1
		RETURN

	DELETE FROM DIEM WHERE MAHS LIKE (SELECT MAHS FROM DELETED)
END

-- Check

SELECT * FROM DSHS

DELETE FROM DSHS WHERE MAHS LIKE '00992'

SELECT * FROM DSHS WHERE MAHS LIKE '00992'

SELECT * FROM DIEM WHERE MAHS LIKE '00992'

/*
6. Viết nội thủ tục (Stored Procedure) cập nhật phần ghi chú là “Chuyển trường từ ngày
5/9/2016” cho học sinh có mã nhập vào trong bảng danh sách học sinh.
*/

CREATE PROC autoNote AS
BEGIN
	UPDATE DSHS SET ghiChu=N'Chuyển trường từ ngày 5/9/2016'
END

EXEC autoNote

-- Check
SELECT * FROM DSHS

/*
7. Tạo View báo cáo Kết thúc năm học gồm các thông tin: Mã học sinh, Họ và tên, Ngày sinh,
Giới tính, Điểm Toán, Lý, Hóa, Văn, Điểm Trung bình, Xếp loại
*/

-- Init

DROP FUNCTION getRank01

CREATE FUNCTION getRank01(@dtb float) RETURNS NVARCHAR(10) AS
BEGIN
	IF @dtb>=8
		RETURN 'Gioi'
	IF @dtb>=6
		RETURN 'Kha'

	RETURN 'Trung binh'
END

-- View
CREATE VIEW ketThucNamHoc AS
SELECT DSHS.MAHS as 'Ma hoc sinh', CONCAT(HO,' ',TEN) as 'Ho va ten', DSHS.NGAYSINH as 'Ngay sinh', IIF(DSHS.NU=0,'Nam','Nu') as 'Gioi tinh', TOAN as 'Toan', LY as 'LY', HOA as 'Hoa', VAN as 'Van', round((TOAN*2+VAN*2+LY+HOA)/6,2) as 'Diem trung binh', dbo.getRank01((TOAN*2+VAN*2+LY+HOA)/6) as 'Xep loai' FROM DSHS INNER JOIN DIEM ON DSHS.MAHS = DIEM.MAHS  

-- Check

SELECT * FROM ketThucNamHoc

/*
8. Tạo trường điểm thấp nhất trong bảng Điểm, tạo thủ tục cập nhật điểm thấp nhất cho trường
này của tất cả các bản ghi đã có (dùng con trỏ)
*/

DECLARE p CURSOR FOR SELECT MAHS FROM DSHS
OPEN p
DECLARE @mahs nvarchar(5)
FETCH NEXT FROM p INTO @mahs
WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @toan float, @hoa float, @van float, @ly float, @min float
		SET @min=@toan
		SELECT @toan=TOAN, @ly=LY, @hoa=HOA, @van=VAN FROM DIEM WHERE @mahs=MAHS

		IF @min<@hoa
			SET @min=@hoa
		IF @min<@ly	
			SET @min=@ly
		IF @min<@van
			SET @min=@van

		UPDATE DIEM SET DTN=@min WHERE @mahs = MAHS

		FETCH NEXT FROM p INTO @mahs
	END

CLOSE p
DEALLOCATE p

/*
9. Tạo trigger cập nhật điểm thấp nhất mỗi khi insert, update một bản ghi vào bảng điểm.
*/

CREATE TRIGGER autoDTN ON DIEM FOR INSERT,UPDATE AS
BEGIN
	DECLARE @toan float, @ly float, @van float, @hoa float, @min float
	SELECT @toan=TOAN, @ly=LY, @hoa=HOA, @van=VAN FROM INSERTED
	
	IF @min<@hoa
		SET @min=@hoa
	IF @min<@ly	
		SET @min=@ly
	IF @min<@van
		SET @min=@van

	UPDATE DIEM SET DTN=@min WHERE MAHS = (SELECT MAHS FROM INSERTED)
END































































































































































































































































































































































/*
10. Tạo View danh sách HOC SINH XUAT SAC bao gồm các học sinh có DTB>=8.5 và
DTN>=8 với các trường: Lop, Mahs, Hoten, Namsinh (năm sinh), Nu, Toan, Ly, Hoa, Van,
DTN, DTB (không dùng trường thấp nhất đã làm ở câu 7)
*/
CREATE view best AS
SELECT DSHS.Lop as 'Lop', DSHS.MAHS as 'Ma hoc sinh', CONCAT(DSHS.HO,' ',DSHS.TEN) as 'Ho va ten', DSHS.NGAYSINH as 'Nam sinh', IIF(DSHS.NU=1,'Nu','Nam') as 'Gioi tinh', TOAN as 'Toan', LY as 'Ly', HOA as 'Hoa', VAN as 'Van', dbo.min4(TOAN,LY,HOA,VAN) as 'Diem thap nhat', ROUND((TOAN*2+VAN*2+LY+HOA)/6,2) as 'Diem Trung binh' FROM DSHS INNER JOIN DIEM ON DIEM.MAHS = DSHS.MAHS WHERE (TOAN*2+VAN*2+LY+HOA)/6 >=8.5 AND dbo.min4(TOAN,VAN,LY,HOA)>=8

-- Check
SELECT * FROM best

/*
11. Tạo View danh sách HOC SINH DAT THU KHOA KY THI bao gồm các học sinh xuất
sắc có DTB lớn nhất với các trường: Lop, Mahs, Hoten, Namsinh, Nu, Toan, Ly, Hoa, Van,
DTB
*/

SELECT TOP(1) WITH TIES * FROM DSHS INNER JOIN DIEM ON DIEM.MAHS = DSHS.MAHS ORDER BY (TOAN*2+VAN*2+HOA+LY/6) DESC

/*12 Thủ khoa và Á khoa BY LE QUANG DUY*/

SELECT * FROM DSHS INNER JOIN DIEM ON DSHS.MAHS=DIEM.MAHS 
WHERE 
	(TOAN*2+VAN*2+LY+HOA)/6 = (SELECT MAX(x.DTB) FROM (SELECT (TOAN*2+VAN*2+HOA+LY)/6 as 'DTB' FROM DIEM) as x)
OR  (TOAN*2+VAN*2+LY+HOA)/6 = (SELECT MAX(x.DTB) FROM (SELECT (TOAN*2+VAN*2+HOA+LY)/6 as 'DTB' FROM DIEM) as x WHERE x.DTB NOT IN (SELECT MAX(x.DTB) FROM (SELECT (TOAN*2+VAN*2+HOA+LY)/6 as 'DTB' FROM DIEM) as x))
ORDER BY (TOAN*2+VAN*2+LY+HOA)/6 DESC
	

/*======================================================BAI2======================================================================*/

USE BT5

SELECT * FROM tDangKy
SELECT * FROM tChiTietKH
SELECT * FROM tKhachHang
SELECT * FROM tLoaiPhong

/*
1. Tạo View gồm các field sau: MaDK, LoaiKH, TenKH,NgaySinh, Phai, DiaChi, DienThoai,
SoPhong, LoaiPhong, NgayVao, SoNgayO.
Trong đó Số Ngày ở = Ngày Ra – Ngày Vao 
*/
CREATE VIEW khachHang AS 
SELECT tDangKy.MaDK as 'MaDK', tKhachHang.LoaiKH as 'LoaiKH', tChiTietKH.TenKH as 'TenKH', tChiTietKH.NgaySinh as 'NgaySinh', IIF(tChiTietKH.Phai=0,'Nu','Nam') as 'Phai', tChiTietKH.DiaChi as 'DiaChi', tChiTietKH.DienThoai as 'DienThoai', tDangKy.SoPhong as 'SoPhong', tLoaiPhong.LoaiPhong as 'LoaiPhong', tDangKy.NgayVao as 'NgayVao', DATEDIFF(DAY,tDangKy.NgayVao,tDangKy.NgayRA) as 'SoNgayO' FROM tDangKy INNER JOIN tChiTietKH ON tChiTietKH.MaDK=tDangKy.MaDK INNER JOIN tLoaiPhong ON tLoaiPhong.LoaiPhong = tDangKy.LoaiPhong INNER JOIN tKhachHang ON tKhachHang.LoaiKH = tChiTietKH.LoaiKH

-- Check
SELECT * FROM khachHang

/*
2. Viết hàm có mã nhập vào là ngày vào trong năm 1999 và thông tin đưa ra như câu 1
*/

CREATE FUNCTION ngayVao1999(@ngayVao datetime) RETURNS TABLE
AS
	RETURN SELECT tDangKy.MaDK as 'MaDK', tKhachHang.LoaiKH as 'LoaiKH', tChiTietKH.TenKH as 'TenKH', tChiTietKH.NgaySinh as 'NgaySinh', IIF(tChiTietKH.Phai=0,'Nu','Nam') as 'Phai', tChiTietKH.DiaChi as 'DiaChi', tChiTietKH.DienThoai as 'DienThoai', tDangKy.SoPhong as 'SoPhong', tLoaiPhong.LoaiPhong as 'LoaiPhong', tDangKy.NgayVao as 'NgayVao', DATEDIFF(DAY,tDangKy.NgayVao,tDangKy.NgayRA) as 'SoNgayO' FROM tDangKy INNER JOIN tChiTietKH ON tChiTietKH.MaDK=tDangKy.MaDK INNER JOIN tLoaiPhong ON tLoaiPhong.LoaiPhong = tDangKy.LoaiPhong INNER JOIN tKhachHang ON tKhachHang.LoaiKH = tChiTietKH.LoaiKH WHERE @ngayVao = NgayVao


-- Check
SELECT * FROM dbo.ngayVao1999(CONVERT(DATETIME,'01/01/1999'))

/*
3. Viết truy vấn tạo bảng doanh thu (tDoanhThu) gồm các trường
Table: tDoanhThu
Tên trường Kiểu dữ liệu Diễn giải
MaDK Short Text Mã đăng ký
LoaiPhong Short Text Loại phòng
SoNgayO Number Số ngày ở
ThucThu Number Thực thu
*/

CREATE TABLE tDoanhThu2(
	[MaDK] [nvarchar](3) PRIMARY KEY NOT NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[SoNgayO] [int] NULL,
	[ThucThu] [bigint] NULL
)

/*
 Tạo Trigger tính tiền và điền tự động vào bảng tDoanhThu như sau:
Các trường lấy thông tin từ các bảng và các thông tin sau:
Trong đó:
(a) Số Ngày Ở= Ngày Ra – Ngày Vào
(b) ThucThu: Tính theo yêu cầu sau:
Nếu Số Ngày ở <10 Thành tiền = Đơn Giá * Số ngày ở
Nếu 10 <=Số Ngày ở <30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.95 (Giảm5%)
Nếu Số ngày ở >= 30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.9 (Giảm10%) 
*/

SELECT * FROM tDangKy

CREATE TRIGGER autoDoanhThu ON tDangKy FOR INSERT,UPDATE AS
BEGIN
	DECLARE @ngayO int,@thanhTien float,@maDk nvarchar(3)
	
	SELECT @ngayO=DATEDIFF(DAY,NgayVao,NgayRa), @maDk=MaDK FROM INSERTED
   
	IF @ngayO<10 
		SELECT @thanhTien=DonGia*@ngayO FROM tLoaiPhong INNER JOIN INSERTED ON tLoaiPhong.LoaiPhong =INSERTED.LoaiPhong
	ELSE IF 10<=@ngayO and @ngayO<30  
		SELECT @thanhTien=DonGia*@ngayO*0.95 FROM tLoaiPhong INNER JOIN INSERTED ON tLoaiPhong.LoaiPhong=INSERTED.LoaiPhong
	ELSE
		SELECT @thanhTien=DonGia*@ngayO*0.9 FROM tLoaiPhong INNER JOIN INSERTED ON tLoaiPhong.LoaiPhong=INSERTED.LoaiPhong
	
	UPDATE tDoanhThu SET SoNgayO=@ngayO, ThucThu=@thanhTien where MaDK=@maDk
END


