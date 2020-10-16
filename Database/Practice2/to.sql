﻿use BT1

/* Câu 1: 1. Tạo view SachGD đưa ra danh sách các sách với các thông tin MaSach,TenSach, tên thể loại,
tổng số lượng nhập, tổng số lượng bán, số lượng tồn do Nhà xuất bản Giáo Dục xuất bản */

CREATE VIEW SachGD as
SELECT MaSach as 'Ma sach', TenSach as 'Ten sach', TenTheLoai as 'Ten the loai', SoLuong as 'So luong nhap', (SELECT SUM(SLBan) FROM tChiTietHDB WHERE tChiTietHDB.MaSach = tSach.MaSach) as 'So luong ban', SoLuong - (SELECT SUM(SLBan) FROM tChiTietHDB WHERE tChiTietHDB.MaSach = tSach.MaSach) as 'So luong ton' FROM tSach INNER JOIN tTheLoai ON tTheLoai.MaTheLoai = tSach.MaTheLoai

SELECT * FROM SachGD

/*Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, TenKH, địa chỉ, điện thoại cho
những khách hàng đã mua hàng với tổng tất cả các trị giá hóa đơn trong năm hiện tại lớn hơn
30.000.000 */

CREATE VIEW KhachVip AS
SELECT tKhachHang.MaKH as 'Ma Khach Hang', (SELECT TenKH FROM tKhachHang a WHERE a.MaKH = tKhachHang.MaKH) as 'Ten Khach Hang', (SELECT DiaChi FROM tKhachHang a WHERE a.MaKH = tKhachHang.MaKH) as 'Dia chi', (SELECT DienThoai FROM tKhachHang a WHERE a.MaKH = tKhachHang.MaKH) as 'Dien thoai', SUM(SLBan*DonGiaBan) as 'Tong hoa don' FROM tKhachHang INNER JOIN tHoaDonBan ON tHoaDonBan.MaKH = tKhachHang.MaKH INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE YEAR(NgayBan) = 2014 GROUP BY tKhachHang.MaKH HAVING SUM(SLBan*DonGiaBAn)>3000000

SELECT * FROM KhachVip

/*Tạo view đưa ra số hóa đơn, trị giá các hóa đơn và tổng toàn bộ trị giá của các hoa đơn do
nhân viên có tên “Trần Huy” lập trong tháng hiện tại*/CREATE VIEW TranHuy ASSELECT tHoaDonBan.SoHDB as 'So hoa don ban', SUM(SLBan*DonGiaBan) as 'Tri gia hoa don', (SELECT SUM(SLBan*DonGiaBan) as 'Tri gia hoa don' FROM tHoaDonBan INNER JOIN tNhanVien ON tHoaDonBan.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayBan) = 1 OR MONTH(NgayBan) = 2) GROUP BY tHoaDonBan.MaNV) as 'Tong tri gia hoa don ban thang 1 va thang 2' FROM tHoaDonBan INNER JOIN tNhanVien ON tHoaDonBan.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayBan) = 1 OR MONTH(NgayBan) = 2) GROUP BY tHoaDonBan.SoHDBUNION ALLSELECT tHoaDonNhap.SoHDN as 'So hoa don nhap', SUM(SLNhap*DonGiaNhap) as 'Tri gia hoa don nhap', (SELECT SUM(SLNhap*DonGiaNhap)  FROM tHoaDonNhap INNER JOIN tNhanVien ON tHoaDonNhap.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDN ON tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN INNER JOIN tSach ON tSach.MaSach = tChiTietHDN.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayNhap) = 1 OR MONTH(NgayNhap) = 6) GROUP BY tHoaDonNhap.MaNV) as 'Tong tri gia hoa don ban thang 1 va t6' FROM tHoaDonNhap INNER JOIN tNhanVien ON tHoaDonNhap.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDN ON tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN  INNER JOIN tSach ON tSach.MaSach = tChiTietHDN.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayNhap) = 1 OR MONTH(NgayNhap) = 6) GROUP BY tHoaDonNhap.SoHDN/*4. Tạo view đưa thông tin các các sách còn tồn */CREATE VIEW DSTON ASSELECT tChiTietHDB.MaSach, (SELECT TenSach FROM tSach a WHERE tChiTietHDB.MaSach = a.MaSach) as 'Ten sach',  (SELECT SoLuong FROM tSach a WHERE tChiTietHDB.MaSach = a.MaSach) - SUM(SLBan) as 'So luong ton', (SELECT DonGiaBan FROM tSach a WHERE tChiTietHDB.MaSach = a.MaSach) as 'Don gia ban', (SELECT TenNXB FROM tNhaXuatBan a WHERE a.MaNXB =  (SELECT b.MaNXB FROM tSach b WHERE b.MaSach = tChiTietHDB.MaSach)) as 'Nha xuat ban', (SELECT TenTheLoai FROM tTheLoai a WHERE a.MaTheLoai =  (SELECT b.MaTheLoai FROM tSach b WHERE b.MaSach = tChiTietHDB.MaSach)) as 'Ten the loai' FROM tChiTietHDB INNER JOIN tSach b ON b.MaSach = tChiTietHDB.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = b.MaNXB GROUP BY tChiTietHDB.MaSachSELECT * FROM DSTON/*5. Tạo view đưa ra danh sách các sách không bán được trong năm 2014.*/CREATE ViEW SACHKHONGBANDUOC2014 ASSELECT a.MaSach, a.TenSach as 'Ten sach khong ban duoc quyen nao nam 2014' FROM tSach a LEFT JOIN (SELECT b.MaSach FROM tSach b INNER JOIN tChiTietHDB ON tChiTietHDB.MaSach = b.MaSach INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB WHERE YEAR(NgayBan)= 2014) as c ON c.MaSach = a.MaSach WHERE c.MaSach IS NULLSELECT * FROM SACHKHONGBANDUOC2014/*6. Tạo view đưa ra danh sách các sách của NXB Giáo Dục không bán được trong năm 2014.*/	/*	[!]Do NXB Giáo Dục không có quyển nào không bán được trong năm 2014 nên lấy NXB Thủ Đô*/SELECT a.MaSach, a.TenSach as 'Ten sach khong ban duoc quyen nao nam 2014 cua NXB Thu Do' FROM tSach a LEFT JOIN (SELECT b.MaSach FROM tSach b INNER JOIN tChiTietHDB ON tChiTietHDB.MaSach = b.MaSach INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB WHERE YEAR(NgayBan)= 2014) as c ON c.MaSach = a.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = a.MaNXB WHERE c.MaSach IS NULL AND tNhaXuatBan.TenNXB LIKE  N'NXB Thủ Đô'/*7. Tạo view đưa ra các thông tin về sách và số lượng từng sách được bán ra trong năm 2014.*/