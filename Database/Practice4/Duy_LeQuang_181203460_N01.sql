USE BT2911

/*
1. Tạo cơ sở dữ liệu trên, với các khóa chính như sau:
ChiTietVanTai là MaVT, TrongTai là MaTrongTai, LoTrinh là MaLoTrinh 
*/

ALTER TABLE ChiTietVanTai 
ADD CONSTRAINT PK_MaVT PRIMARY KEY (MAVT)

ALTER TABLE TrongTai
ADD CONSTRAINT PK_MaTrongTai PRIMARY KEY (MaTrongTai)

ALTER TABLE LoTrinh
ADD CONSTRAINT PK_MaLoTrinh PRIMARY KEY (MaLoTrinh)

/*
2. Tạo view gồm các trường SoXe, MaLoTrinh, SoLuongVT, NgayDi, NgayDen,
ThoiGianVT, CuocPhi, Thuong. Trong đó:
• ThoiGianVT: là 1 nếu vận chuyển trong ngày, là (NgayDen-NgayDi) trong trường hợp
ngược lại.
• CuocPhi: là SoLuongVT x DonGia x 105% nếu SoLuongVT nhiều hơn TrongTaiQD, là
SoLuongVT x DonGia trong trường hợp ngược lại.
• Thuong: là 5% của CuocPhi nếu ThoiGianVT vuot ThoiGianQD, là 0 trong trường hợp
ngược lại. 
*/

CREATE VIEW View02 AS
	SELECT SoXe,ChiTietVanTai.MaLoTrinh,SoLuongVT,NgayDi,NgayDen,DATEDIFF(DAY,NgayDi,NgayDen)+1 as 'ThoiGianVT',dbo.CuocPhi(SoLuongVT,DonGia,TrongTaiQD) as 'CuocPhi', IIF(ThoiGianQD<DATEDIFF(DAY,NgayDi,NgayDen)+1,dbo.CuocPhi(SoLuongVT,DonGia,TrongTaiQD)*0.05,0) as 'Thuong' FROM ChiTietVanTai INNER JOIN LoTrinh ON ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai

SELECT * FROM View02

CREATE FUNCTION CuocPhi(@SoLuongVt int,@DonGia int,@TrongTaiQD int) RETURNS money AS
BEGIN
	DECLARE @res money
	IF @SoLuongVt>@TrongTaiQD
		SET @res = @SoLuongVt*@DonGia*1.05
	ELSE
		SET @res = @SoLuongVt*@DonGia
	RETURN @res
END 

/*
3. Tạo view để lập bảng cước phí gồm các trường SoXe, TenLoTrinh, SoLuongVT, NgayDi,
NgayDen, CuocPhi. 
*/
CREATE VIEW Cuoc AS
	SELECT SoXe,TenLoTrinh,SoLuongVT,NgayDi,NgayDen,dbo.CuocPhi(SoLuongVT,DonGia,TrongTaiQD) as 'Cuoc' FROM ChiTietVanTai INNER JOIN LoTrinh ON LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai

SELECT * FROM Cuoc

/*
4. Tạo view danh sách các xe có có SoLuongVT vượt trọng tải qui định, gồm các trường
SoXe, TenLoTrinh, SoLuongVT, TronTaiQD, NgayDi, NgayDen. 
*/
CREATE VIEW SoLuongVanTaiVuotQuyDinh AS
	SELECT SoXe,TenLoTrinh,SoLuongVT,TrongTaiQD,NgayDi,NgayDen FROM ChiTietVanTai INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai INNER JOIN LoTrinh ON LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh WHERE SoLuongVT>TrongTaiQD

SELECT * FROM SoLuongVanTaiVuotQuyDinh

/*
5. Tạo hàm có đầu vào là lộ trình, đầu ra là số xe, mã trọng tải, số lượng vận tải, ngày đi, ngày
đến (SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen.)
*/

CREATE FUNCTION exLoTrinh(@maLoTrinh nvarchar(255)) RETURNS TABLE AS
	RETURN SELECT SoXe,TrongTai.MaTrongTai,SoLuongVT,NgayDi,NgayDen FROM ChiTietVanTai INNER JOIN LoTrinh ON ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh INNER JOIN TrongTai ON ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai WHERE LoTrinh.MaLoTrinh = @maLoTrinh

SELECT * FROM dbo.exLoTrinh('DN')

/*
6. Thiết lập hàm có đầu vào là số xe, đầu ra là thông tin về lộ trình*/CREATE FUNCTION ThongTinLoTrinh (@soXe nvarchar(255)) RETURNS TABLE AS RETURN SELECT LoTrinh.MaLoTrinh,TenLoTrinh,DonGia,ThoiGianQD FROM ChiTietVanTai INNER JOIN LoTrinh ON LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh WHERE SoXe = @soXeSELECT * FROM dbo.ThongTinLoTrinh('333')/*7. Thêm trường Thành tiền vào bảng chi tiết vận tải và tạo trigger điền dữ liệu cho trường này
biết:
Thành tiền = là SoLuongVT x DonGia x 105% nếu SoLuongVT nhiều hơn TrongTaiQD, là
SoLuongVT x DonGia trong trường hợp ngược lại*/ALTER TABLE ChiTietVanTai ADD ThanhTien moneyCREATE TRIGGER updateThanhTien ON ChiTietVanTai FOR INSERT,UPDATE, DELETE ASBEGIN	DECLARE @SoLuongVT int, @DonGia int, @TrongTaiQD int	SELECT @SoLuongVT=SoLuongVt, @DonGia= DonGia, @TrongTaiQD = TrongTaiQD FROM ChiTietVanTai INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai INNER JOIN LoTrinh ON LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh WHERE ChiTietVanTai.MaVT = (SELECT MaVT FROM INSERTED)		UPDATE ChiTietVanTai SET ThanhTien = dbo.CuocPhi(@SoLuongVT,@DonGia,@TrongTaiQD) WHERE MaVT = (SELECT MAVT FROM INSERTED)END/*8. Tạo thủ tục có đầu vào là mã lộ trình, năm vận tải, đầu ra là số tiền theo mã lộ trình đó*/CREATE PROC exMoneyLoTrinhNamVanTai @MaLT nvarchar(255), @namVT int, @money money output  ASBEGIN	SELECT @money = SUM(dbo.CuocPhi(SoLuongVT,DonGia,TrongTaiQD)) FROM LoTrinh INNER JOIN ChiTietVanTai ON ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai WHERE YEAR(NgayDi) = @namVT AND LoTrinh.MaLoTrinh = @MaLTENDDECLARE @MaLT nvarchar(255), @namVT int, @money moneySET @MaLT = 'HN'SET @namVT = 2014EXEC dbo.exMoneyLoTrinhNamVanTai @MaLT, @namVT, @money outputprint @money/*9. Tạo thủ tục có đầu vào là số xe, năm vận tải, đầu ra là số tiền theo mã lộ trình đó*/CREATE PROC exMoneySoXeNamVanTai @SoXe nvarchar(255), @namVT int, @money money output  ASBEGIN	SELECT @money = SUM(dbo.CuocPhi(SoLuongVT,DonGia,TrongTaiQD)) FROM LoTrinh INNER JOIN ChiTietVanTai ON ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai WHERE YEAR(NgayDi) = @namVT AND ChiTietVanTai.SoXe = @SoXeEND	SELECT SUM(dbo.CuocPhi(SoLuongVT,DonGia,TrongTaiQD)) FROM LoTrinh INNER JOIN ChiTietVanTai ON ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh INNER JOIN TrongTai ON TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai WHERE YEAR(NgayDi) = 2014 AND ChiTietVanTai.SoXe = '333'DECLARE @SoXe nvarchar(255), @namVT int, @money moneySET @SoXe = '333'SET @namVT = 2014EXEC dbo.exMoneySoXeNamVanTai @SoXe, @namVT, @money outputprint @money/*===============================================================================================================*/USE BT29112/*1. Tạo view KET QUA chứa kết quả thi của từng học sinh bao gồm các thông tin: SoBD,
HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem, XepLoai, DTDuThi
Biết rằng: TongDiem = Toan + Van + AnhVan + DiemUT
XepLoai học sinh như sau:
* Giỏi nếu TongDiem>=24 và tất cả các môn >=7
* Khá nếu TongDiem>=21 và tất cả các môn >=6
* Trung Bình nếu TongDiem>=15 và tất cả các môn >=4
* Trượt nếu ngược lại */CREATE FUNCTION XepLoai (@toan real, @ly real, @AnhVan real, @DiemUT int) RETURNS NVARCHAR(100) ASBEGIN	DECLARE @res NVARCHAR(100)	IF (@toan+@ly+@AnhVan+@DiemUT)>=24 AND @toan>=7 AND @ly>=7 AND @AnhVan>=7 		SET @res = N'Giỏi'	ELSE IF (@toan+@ly+@AnhVan+@DiemUT)>=21 AND @toan>=6 AND @ly>=6 AND @AnhVan>=6		SET @res = N'Khá'	ELSE IF (@toan+@ly+@AnhVan+@DiemUT)>=15 AND @toan>=4 AND @ly>=4 AND @AnhVan>=4		SET @res = N'Trung Bình'	ELSE 		SET @res = N'Trượt'	RETURN @resENDCREATE VIEW KETQUA1 AS	SELECT DanhSach.SoBD ,CONCAT(Ho,' ', Ten) as 'HoTen', IIF(Phai=0,'Nu','Nam') as 'Phai', DATEDIFF(YEAR,NTNS,GETDATE()) as 'Tuoi', Toan, Van, AnhVan, (Toan+Van+AnhVan+DiemUT) as 'Tong Diem', dbo.XepLoai(Toan,Van,AnhVan,DiemUT) 'XepLoai', DanhSach.DTDuThi FROM DanhSach INNER JOIN ChiTietDT ON ChiTietDT.DTDuThi = DanhSach.DTDuThi INNER JOIN DiemThi On Diemthi.SoBD = DanhSach.SoBDSELECT * FROM KETQUA1 /*2. Tạo view GIOI TOAN – VAN – ANH VAN bao gồm các học sinh có ít nhất 1 môn 10 và
có TongDiem>=25 bao gồm các thông tin: SoBD, HoTen, Toan, Van, AnhVan, TongDiem,
DienGiaiDT*/CREATE VIEW GIOI AS	SELECT DiemThi.SoBD, CONCAT(Ho,' ',Ten) as 'Ho va ten', Toan, Van, AnhVan, (Toan+Van+AnhVan+DiemUT) as 'Tong Diem', DienGiaiDT FROM ChiTietDT INNER JOIN DanhSach ON DanhSach.DTDuThi = ChiTietDT.DTDuThi INNER JOIN DiemThi ON DanhSach.SoBD = DiemThi.SoBD WHERE (Toan+Van+AnhVan+DiemUT)>=25 AND (Toan = 10 OR Van = 10 OR AnhVan=10)SELECT * FROM GIOI/*3. Tạo view DANH SACH DAU (ĐẬU) gồm các học sinh có XepLoai là Giỏi, Khá hoặc
Trung Bình với các field: SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem,
XepLoai, DTDuThi*/CREATE VIEW DAU AS	SELECT DiemThi.SoBD, CONCAT(Ho,' ',Ten) as 'Ho va ten', Toan, Van, AnhVan, (Toan+Van+AnhVan+DiemUT) as 'Tong Diem',dbo.XepLoai(Toan,Van,AnhVan,DiemUT) as 'Xep loai', DienGiaiDT FROM DanhSach INNER JOIN DiemThi ON DiemThi.SoBD=DanhSach.SoBD INNER JOIN ChiTietDT ON ChiTietDT.DTDuThi=DanhSach.DTDuThi WHERE dbo.XepLoai(Toan,Van,AnhVan,DiemUT) != N'Trượt'SELECT * FROM DAU/*4. Tạo view HOC SINH DAT THU KHOA KY THI bao gồm các học sinh “ĐẬU” có
TongDiem lớn nhất với các field: SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem,
DienGiaiDT*/CREATE VIEW THUKHOA AS	SELECT DiemThi.SoBD, CONCAT(Ho,' ',Ten) as 'Ho va ten', Toan, Van, AnhVan, (Toan+Van+AnhVan+DiemUT) as 'Tong Diem',dbo.XepLoai(Toan,Van,AnhVan,DiemUT) as 'Xep loai', DienGiaiDT FROM DanhSach INNER JOIN DiemThi ON DiemThi.SoBD = DanhSach.SoBD INNER JOIN ChiTietDT ON ChiTietDT.DTDuThi = DanhSAch.DTDuThi WHERE dbo.XepLoai(Toan,Van,AnhVan,DiemUT) != N'Trượt' AND (Toan+Van+AnhVan+DiemUT) = (SELECT MAX(Toan+Van+AnhVan+DiemUT) FROM DanhSach INNER JOIN DiemThi ON DiemThi.SoBD = DanhSach.SoBD INNER JOIN ChiTietDT ON ChiTietDT.DTDuThi = DanhSAch.DTDuThi WHERE dbo.XepLoai(Toan,Van,AnhVan,DiemUT) != N'Trượt')SELECT * FROM THUKHOA/*5. Tạo thủ tục có đầu vào là số báo danh, đầu ra là các điểm thi, điểm ưu tiên và tổng điểm*/CREATE PROC inSBD @soBD int ASBEGIN	SELECT Toan,Van,AnhVan,DiemUT,(Toan+Van+AnhVan+DiemUT) as 'Tong diem' FROM DiemThi INNER JOIN DanhSach ON DanhSach.SoBD = DiemThi.SoBD INNER JOIN ChiTietDT ON DanhSach.DTDuThi = ChiTietDT.DTDuThi WHERE DiemThi.SoBD = @soBD ENDEXEC inSBD '1'/*6. Tạo trigger kiểm tra xem việc nhập mã đối tượng dự thi trong bảng danh sách có đúng với
bảng đối tượng dự thi không*/ALTER TRIGGER checkConstraint ON DanhSach FOR INSERT,UPDATE ASBEGIN	DECLARE @dtDuThi tinyint = null	SELECT @dtDuThi = DTDuThi FROM ChiTietDT WHERE DTDuThi = (SELECT DTDuThi FROM INSERTED)	IF @dtDuThi is null		BEGIN			rollback tran		ENDEND/*7. Thêm trường điểm ưu tiên và tổng điểm vào bảng Điểm thi. Tạo trigger cập nhật tự động
trường ưu tiên và tổng điểm mỗi khi nhập hay chỉnh sửa*/ALTER TABLE DiemThi ADD UUTIEN intALTER TABLE DiemThi ADD TongDiem realCREATE TRIGGER updateDiemThi1 ON ChiTietDT FOR INSERT,UPDATE ASBEGIN	UPDATE DiemThi SET UUTIEN = (SELECT DiemUT FROM INSERTED),TongDiem = Toan+Van+AnhVan + (SELECT DiemUT FROM INSERTED)  FROM DanhSach INNER JOIN DiemThi ON DiemThi.SoBD = DanhSach.SoBD INNER JOIN ChiTietDT ON ChiTietDT.DTDuThi = DanhSach.DTDuThi WHERE ChiTietDT.DTDuThi = (SELECT DTDuThi FROM INSERTED)ENDCREATE TRIGGER updateDiemThi2 ON DiemThi FOR INSERT,UPDATE ASBEGIN	IF TRIGGER_NESTLEVEL()>1		RETURN	UPDATE DiemThi SET TongDiem = (Toan+Van+AnhVan+DiemUT) FROM DanhSach INNER JOIN DiemThi ON DiemThi.SoBD = DanhSach.SoBD INNER JOIN ChiTietDT ON ChiTietDT.DTDuThi = DanhSach.DTDuThi WHERE DiemThi.SoBD = (SELECT SoBD FROM INSERTED)END/* CHECK */SELECT * FROM ChiTietDTUPDATE ChiTietDT SET DiemUT = 2 WHERE ChiTietDT.DTDuThi = 3SELECT * FROM DiemThiUPDATE DiemThi SET Toan = 1 WHERE SoBD = '1'/*8. Tạo trigger xóa tự động bản ghi tương ứng ở bảng điểm khi xóa bản ghi ở danh sách*/DROP TRIGGER autoDeleteCREATE TRIGGER autoDelete ON DanhSach INSTEAD OF DELETE ASBEGIN	DELETE DiemThi WHERE SoBD = (SELECT SoBD FROM DELETED)	DELETE DanhSach WHERE SoBD = (SELECT SoBD FROM DELETED)END/*Test*/DELETE DanhSach WHERE SoBD='11'SELECT * FROM DIEMTHI WHERE SoBD = '11'/*Ending and Thank you !*/