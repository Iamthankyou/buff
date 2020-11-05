USE BT1																																																																																																																																																																																																																					

/*
Tạo thủ tục đưa ra số tiền của khách hàng đa mua trong năm 2014 khi nhập mã khách
*/

ALTER PROC tongHop @ngayVao nvarchar(10), @doanhThu money output AS
BEGIN
	DECLARE @dateTime datetime
	SET @dateTime = CONVERT(DATETIME,'1/'+@ngayVao,103)
	print @dateTime
	SELECT @doanhThu = SUM(tSach.DonGiaBan*tChiTietHDB.SLBan) FROM tKhachHang INNER JOIN tHoaDonBan ON tHoaDonBan.MaKH = tKhachHang.MaKH INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE YEAR(tHoaDonBan.NgayBan)=YEAR(@dateTime) AND MONTH(tHoaDonBan.NgayBan) = MONTH(@dateTime)
END

DECLARE @output money
EXEC tongHop '05/2014', @output out
print @output

/*
Tạo hàm có đầu vào là mã nhà xuất bản, đầu ra là danh sách các sách của nhà xuất bản đó
*/

DROP FUNCTION nhaXuatBan

CREATE FUNCTION nhaXuatBan(@in nvarchar(10)) RETURNS TABLE AS
RETURN (SELECT tSach.TenSach FROM tNhaXuatBan INNER JOIN tSach ON tSach.MaNXB=tNhaXuatBan.MaNXB WHERE tNhaXuatBan.MaNXB=@in)


SELECT * FROM dbo.nhaXuatBan('NXB05')

/*
Tạo hàm có đầu vào là năm đầu ra là danh sách và số lượng mỗi đầu sách bán ra trong năm đó
*/

CREATE FUNCTION 

SELECT * FROM tHoaDonBan INNER JOIN tChiTietHDB ON tHoaDonBan.SoHDB=tChiTietHDB.SoHDB INNER JOIN tSach ON tSach.MaSach=tChiTietHDB.MaSach WHERE YEAR(tHoaDonBan.NgayBan)=2014


SELECT SUM(tChiTietHDB.SLBan),tSach.TenSach FROM tHoaDonBan INNER JOIN tChiTietHDB ON tHoaDonBan.SoHDB=tChiTietHDB.SoHDB INNER JOIN tSach ON tSach.MaSach=tChiTietHDB.MaSach WHERE YEAR(tHoaDonBan.NgayBan)=2014 GROUP BY tSach.TenSach,tSach.MaSach

SELECT * FROM tSach WHERE MaSach LIKe 'S100'
INSERT INTO tSach(MaSach,TenSach) VALUES('S100','Database')
INSERT INTO tSach(MaSach,TenSach) VALUES('S101','Database')

SELECT * FROM tHoaDonBan
SELECT * FROM tKhachHang
INSERT INTO tHoaDonBan(SoHDB,MaNV,NgayBan,MaKH) VALUES('HDB100','NV05',CONVERT(DATETIME,'01/01/2014'),'KH04')

SELECT * FROM tChiTietHDB

INSERT INTO tChiTietHDB(SoHDB,MaSach,SLBan) VALUES('HDB100','S100',10)

INSERT INTO tChiTietHDB(SoHDB,MaSach,SLBan) VALUES('HDB100','S101',11)

SELECT * FROM tChiTietHDB WHERE SoHDB LIke 'HDB100'





