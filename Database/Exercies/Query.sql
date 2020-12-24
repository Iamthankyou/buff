USE QLBanDienThoai

/*Tạo thủ tục có đầu vào là ngày hóa đơn, đầu ra là số mặt hàng bán trong ngày đó*/

ALTER PROC numsDay @day nvarchar(20), @res int output AS 
BEGIN
	DECLARE @date DATETIME
	SET @date = CONVERT(DATE,@day,103)

	SELECT @res = SUM(SlBan) FROM Hoadon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = HoaDon.MaHD WHERE YEAR(NgayBan)=YEAR(@date) AND MONTH(NgayBan) = MONTH(@date) AND DAY(NgayBan) = DAY(@date)
END 

SELECT * FROM Hoadon

DECLARE @res INT
EXEC numsDay '16/03/2015', @res output
print @res

SELECT * FROM HoaDon INNER JOIN ChiTietHD ON Hoadon.MaHD = ChiTietHD.MaHD WHERE NgayBan = CONVERT(DATE,'16/03/2015',103)

/*Tạo hàm có đầu vào là mã khách hàng, năm, đầu ra là danh sách các hóa đơn khách hàng mua trong năm */

CREATE FUNCTION exCustomerYear(@idCustomer nvarchar(10), @year int) RETURNS TABLE AS 
	RETURN (SELECT KhachHang.MaKH AS N'Mã KH',  Hoadon.MaHD AS N'Mã HD', Hoadon.Ngayban AS N'Ngày mua',  SUM(SanPham.GiaSP*ChiTietHD.SlBan) as N'Tổng tiền' FROM KhachHang INNER JOIN Hoadon ON Hoadon.MaKH = KhachHang.MaKH INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP WHERE KhachHang.MaKH = '0002' AND YEAR(NgayBan) = 2015 GROUP BY Hoadon.MaHD, KhachHang.MaKH,HoaDon.Ngayban)

SELECT * FROM Hoadon INNER JOIN ChiTietHD ON Hoadon.MaHD = ChiTietHD.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP WHERE Hoadon.MaHD = '0032'

SELECT * FROM Hoadon

INSERT INTO Hoadon(MaHD,MaKH,MaNV,Ngayban) VALUES('0033','0002','0001','2015-03-16')

SELECT * FROM ChiTietHD 

INSERT INTO ChiTietHD(MaHD,MaSP,SlBan) VALUES('0033','0002',2)

SELECT * FROM dbo.exCustomerYear('0002',2015)

SELECT * FROM dbo.cau3('0002')

/*Tạo View thống kê hàng tồn dựa trên số lượng nhập và bán trong năm 2015 */

SELECT ChiTietHDN.MaSP as N'Mã Hàng', SanPham.TenSP as N'Tên Hàng', SUM(ChiTietHDN.SLN) as N'Số Lượng Nhập', SUM(ChiTietHD.SlBan) as N'Số Lượng xuất',ISNULL(SUM(ChiTietHDN.SLN),0) - ISNULL(SUM(ChiTietHD.SlBan),0) as N'Tồn' FROM HoaDon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP INNER JOIN ChiTietHDN ON ChiTietHDN.MaSP = SanPham.MaSP INNER JOIN HoaDonNhap ON HoaDonNhap.MaHDN = ChiTietHDN.MaHDN WHERE YEAR(Ngayban) = 2015 AND YEAR(HoaDonNhap.NgayNhap)=2015 GROUP BY ChiTietHDN.MaSP,SanPham.TenSP


SELECT * FROM HoaDon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP LEFT JOIN ChiTietHDN ON ChiTietHDN.MaSP = SanPham.MaSP LEFT JOIN HoaDonNhap ON HoaDonNhap.MaHDN = ChiTietHDN.MaHDN WHERE YEAR(Ngayban) = 2015 AND YEAR(HoaDonNhap.NgayNhap)=2015  AND SanPham.MaSP = '0001'

SELECT DISTINCT * FROM HoaDon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP LEFT JOIN ChiTietHDN ON ChiTietHDN.MaSP = SanPham.MaSP LEFT JOIN HoaDonNhap ON HoaDonNhap.MaHDN = ChiTietHDN.MaHDN WHERE YEAR(Ngayban) = 2015 AND YEAR(HoaDonNhap.NgayNhap)=2015  AND SanPham.MaSP = '0001'



SELECT SUM(SLN) FROM HoaDon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP INNER JOIN ChiTietHDN ON ChiTietHDN.MaSP = SanPham.MaSP INNER JOIN HoaDonNhap ON HoaDonNhap.MaHDN = ChiTietHDN.MaHDN WHERE YEAR(Ngayban) = 2015 AND YEAR(HoaDonNhap.NgayNhap)=2015  AND SanPham.MaSP = '0001' GROUP BY HoaDonNhap.MaHDN

-- OK

SELECT SanPham.MaSP as N'Mã Hàng', SanPham.TenSP as N'Tên Hàng', (SELECT SUM(ISNULL(SLN,0)) FROM HoaDonNhap INNER JOIN ChiTietHDN ON ChiTietHDN.MaHDN = HoaDonNhap.MaHDN WHERE ChiTietHDN.MaSP = SanPham.MaSP GROUP BY ChiTietHDN.MaSP) as N'Số Lượng Nhập', (SELECT SUM(ISNULL(Slban,0)) FROM Hoadon INNER JOIN ChiTietHD ON Hoadon.MaHD = ChiTietHD.MaHD WHERE ChiTietHD.MaSP = SanPham.MaSP GROUP BY ChiTietHD.MaSP) AS  N'Số Lượng Bán',(SELECT SUM(ISNULL(SLN,0)) FROM HoaDonNhap INNER JOIN ChiTietHDN ON ChiTietHDN.MaHDN = HoaDonNhap.MaHDN WHERE ChiTietHDN.MaSP = SanPham.MaSP GROUP BY ChiTietHDN.MaSP)-(SELECT SUM(ISNULL(Slban,0)) FROM Hoadon INNER JOIN ChiTietHD ON Hoadon.MaHD = ChiTietHD.MaHD WHERE ChiTietHD.MaSP = SanPham.MaSP GROUP BY ChiTietHD.MaSP) as N'Số Lượng Tồn' FROM SanPham

SELECT hdn.masp,hdn.slnhap,hdb.slb,hdn.slnhap-hdb.slb FROM (SELECT SUM(ISNULL(SLN,0)) as slnhap, ChiTietHDN.MaSP as masp FROM HoaDonNhap INNER JOIN ChiTietHDN ON HoaDonNhap.MaHDN = ChiTietHDN.MaHDN GROUP BY ChiTietHDN.MaSP) as hdn INNER JOIN (SELECT SUM(ISNULL(Slban,0)) as slb, ChiTietHD.MaSP as msp, SanPham.TenSP as tensp FROM Hoadon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP GROUP BY ChiTietHD.MaSP,SanPham.TenSP) as hdb ON hdb.msp = hdn.masp

SELECT * FROM HoaDon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD INNER JOIN SanPham ON SanPham.MaSP = ChiTietHD.MaSP WHERE YEAR(Ngayban) = 2015 AND SanPham.MaSP = '0001'

select b.MaSP as "Mã hàng", TenSP as "Tên Hàng", isnull(SlN,0) as "Số lượng nhập",isnull(SlBan,0) as "Số lượng bán", isnull(SlN,0) - isnull(SlBan,0) as "Tồn" from (select masp, sum(slBan) as SLBan from ChiTietHD join Hoadon on Hoadon.MaHD =  ChiTietHD.MaHD where YEAR(Ngayban) = 2015 group by MaSP) a full join (select SanPham.MaSP,TenSP, sum(SlN) as SLN from ChiTietHDN inner join SanPham on ChiTietHDN.MaSP = SanPham.MaSP inner join HoaDonNhap on HoaDonNhap.MaHDN = ChiTietHDN.MaHDN where YEAR(NgayNhap) = 2015 group by SanPham.MaSP,TenSP) b on a.MaSP=b.MaSP

create function Cau3(@maKH nvarchar(5)) returns table as
return(
	select e.MaKH as "Mã KH", MaHD as "Mã hóa đơn",Ngayban as "Ngày Mua", DBO.TongTien(f.MaHD) as "Tổng Tiền" from KhachHang e join Hoadon f on e.MaKH = f.MaKH Where year(Ngayban) = 2015 and e.MaKH = @maKH
)


create function TongTien(@maHD nvarchar(5)) returns bigint as
begin
	declare @tt bigint
	select @tt = Sum(GiaSP*SlBan) from (SanPham a join ChiTietHD b on a.MaSP = b.MaSP) join Hoadon c on c.MaHD = b.MaHD Where c.MaHD = @maHD
	group by c.MaHD
	return @tt
end

/*Thêm các trường Số lượng hàng mua vào Hóa đơn. Tạo Trigger cập nhật tự động cho trường này. (tính tổng số lượng bán của toàn bộ hàng trong mỗi hóa đơn)*/

ALTER TABLE Hoadon ADD SLMua int

SELECT * FROM Hoadon

SELECT SUM(SLban) FROM Hoadon INNER JOIN ChiTietHD ON Hoadon.MaHD = ChiTietHD.MaHD GROUP BY Hoadon.MaHD

CREATE TRIGGER autoUpdateSLMua ON ChiTietHD FOR INSERT,DELETE,UPDATE AS 
BEGIN
	DECLARE @mahd nvarchar(10)
	SELECT @mahd = MaHD FROM INSERTED
	UPDATE Hoadon SET SLMua = (SELECT SUM(SLban) FROM Hoadon INNER JOIN INSERTED ON Hoadon.MaHD = INSERTED.MaHD GROUP BY Hoadon.MaHD ) WHERE Hoadon.MaHD = @mahd
END

DROP TRIGGER autoUpdateSLMua

SELECT * FROM Hoadon

SELECT * FROM ChiTietHD

INSERT INTO ChiTietHD(MaHD,MaSP,SlBan) VALUES('0034','0001',2)
INSERT INTO ChiTietHD(MaHD,MaSP,SlBan) VALUES('0034','0002',4)

INSERT INTO HoaDon(MaHD,MaKH,MaNV,Ngayban) VALUES('0034','0003','0001','2015-03-16') 

/*
Câu 6: (1 điểm) Tạo hai login A và B, gán quyền Select, Insert, Update cho A trên bảng Hóa đơn và chi tiết hóa đơn, cho phép A được phép gán những quyền này cho người khác
A gán quyền cho B, hãy đăng nhập dưới tài khoản B để kiểm tra
*/

exec sp_addlogin A,'123456'
exec sp_adduser A,AU

exec sp_addlogin B,'123456'
exec sp_adduser B,BU

GRANT SELECT,UPDATE,INSERT ON HoaDon to AU WITH GRANT OPTION

GRANT INSERT ON HoaDon to BU 

SELECT * FROM ChiTietHD

DECLARE p CURSOR FOR SELECT MaHD FROM Hoadon
OPEN p
DECLARE @mahd nvarchar(10)
FETCH NEXT FROM p INTO @mahd

WHILE @@FETCH_STATUS = 0
	BEGIN
		print @mahd
		FETCH NEXT FROM p INTO @mahd
	END

CLOSE p
DEALLOCATE p

SELECT ISNULL(MaSP,'SUM') as SlBan ,SUM(SlBan) as 'Nums' FROM Hoadon INNER JOIN ChiTietHD ON Hoadon.MaHD = ChiTietHD.MaHD GROUP BY ROLLUP(MaSP)


SELECT * FROM Hoadon

SELECT N'Số Lượng Bán' AS N'Ngày',[15],[16],[17],[18] 
FROM (SELECT Slban, DAY(NgayBan) as y FROM Hoadon INNER JOIN ChiTietHD ON ChiTietHD.MaHD = Hoadon.MaHD) as x
PIVOT (SUM(Slban) FOR x.y IN ([15],[16],[17],[18])) as y;


