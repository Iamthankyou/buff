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








