
/*====================================================================BAI1======================================================================*/
use BT1

/* 1. Tạo view SachGD đưa ra danh sách các sách với các thông tin MaSach,TenSach, tên thể loại, tổng số lượng nhập, tổng số lượng bán, số lượng tồn do Nhà xuất bản Giáo Dục xuất bản */

CREATE VIEW SachGD as
SELECT MaSach as 'Ma sach', TenSach as 'Ten sach', TenTheLoai as 'Ten the loai', SoLuong as 'So luong nhap', (SELECT SUM(SLBan) FROM tChiTietHDB WHERE tChiTietHDB.MaSach = tSach.MaSach) as 'So luong ban', SoLuong - (SELECT SUM(SLBan) FROM tChiTietHDB WHERE tChiTietHDB.MaSach = tSach.MaSach) as 'So luong ton' FROM tSach INNER JOIN tTheLoai ON tTheLoai.MaTheLoai = tSach.MaTheLoai

SELECT * FROM SachGD

/*2.Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, TenKH, địa chỉ, điện thoại cho những khách hàng đã mua hàng với tổng tất cả các trị giá hóa đơn trong năm hiện tại lớn hơn
30.000.000 */
CREATE VIEW KhachVip AS
SELECT tKhachHang.MaKH as 'Ma Khach Hang', (SELECT TenKH FROM tKhachHang a WHERE a.MaKH = tKhachHang.MaKH) as 'Ten Khach Hang', (SELECT DiaChi FROM tKhachHang a WHERE a.MaKH = tKhachHang.MaKH) as 'Dia chi', (SELECT DienThoai FROM tKhachHang a WHERE a.MaKH = tKhachHang.MaKH) as 'Dien thoai', SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) as 'Tong hoa don' FROM tKhachHang INNER JOIN tHoaDonBan ON tHoaDonBan.MaKH = tKhachHang.MaKH INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE YEAR(NgayBan) = 2014 GROUP BY tKhachHang.MaKH HAVING SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) >3000000

SELECT * FROM KhachVip

-- Kiểm tra khuyến mại
UPDATE tChiTietHDB SET KhuyenMai=NULL WHERE SoHDB LIKE 'HDB01'

/*3.Tạo view đưa ra số hóa đơn, trị giá các hóa đơn và tổng toàn bộ trị giá của các hoa đơn do nhân viên có tên “Trần Huy” lập trong tháng hiện tại
*/

CREATE VIEW TranHuy AS

SELECT tHoaDonBan.SoHDB as 'So hoa don ban', SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) as 'Tri gia hoa don', (SELECT SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) as 'Tri gia hoa don' FROM tHoaDonBan INNER JOIN tNhanVien ON tHoaDonBan.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayBan) = 1 OR MONTH(NgayBan) = 2) GROUP BY tHoaDonBan.MaNV
) as 'Tong tri gia hoa don ban thang 1 va thang 2' FROM tHoaDonBan INNER JOIN tNhanVien ON tHoaDonBan.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayBan) = 1 OR MONTH(NgayBan) = 2) GROUP BY tHoaDonBan.SoHDB

UNION ALL

SELECT tHoaDonNhap.SoHDN as 'So hoa don nhap', SUM(SLNhap*DonGiaNhap*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)
) as 'Tri gia hoa don nhap', (SELECT SUM(SLNhap*DonGiaNhap*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)
)  FROM tHoaDonNhap INNER JOIN tNhanVien ON tHoaDonNhap.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDN ON tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN INNER JOIN tSach ON tSach.MaSach = tChiTietHDN.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayNhap) = 1 OR MONTH(NgayNhap) = 6) GROUP BY tHoaDonNhap.MaNV
) as 'Tong tri gia hoa don ban thang 1 va t6' FROM tHoaDonNhap INNER JOIN tNhanVien ON tHoaDonNhap.MaNV = tNhanVien.MaNV INNER JOIN tChiTietHDN ON tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN  INNER JOIN tSach ON tSach.MaSach = tChiTietHDN.MaSach WHERE TenNV LIKE N'Trần Huy' AND (MONTH(NgayNhap) = 1 OR MONTH(NgayNhap) = 6) GROUP BY tHoaDonNhap.SoHDN

SELECT * FROM TranHuy
/*
4. Tạo view đưa thông tin các các sách còn tồn 
*/

CREATE VIEW DSTON AS
SELECT tChiTietHDB.MaSach, (SELECT TenSach FROM tSach a WHERE tChiTietHDB.MaSach = a.MaSach) as 'Ten sach',  (SELECT SoLuong FROM tSach a WHERE tChiTietHDB.MaSach = a.MaSach) - SUM(SLBan) as 'So luong ton', (SELECT DonGiaBan FROM tSach a WHERE tChiTietHDB.MaSach = a.MaSach) as 'Don gia ban', (SELECT TenNXB FROM tNhaXuatBan a WHERE a.MaNXB =  (SELECT b.MaNXB FROM tSach b WHERE b.MaSach = tChiTietHDB.MaSach)) as 'Nha xuat ban', (SELECT TenTheLoai FROM tTheLoai a WHERE a.MaTheLoai =  (SELECT b.MaTheLoai FROM tSach b WHERE b.MaSach = tChiTietHDB.MaSach)) as 'Ten the loai' FROM tChiTietHDB INNER JOIN tSach b ON b.MaSach = tChiTietHDB.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = b.MaNXB GROUP BY tChiTietHDB.MaSach

SELECT * FROM DSTON

/*
5. Tạo view đưa ra danh sách các sách không bán được trong năm 2014.
*/

CREATE ViEW SACHKHONGBANDUOC2014 AS
SELECT a.MaSach, a.TenSach as 'Ten sach khong ban duoc quyen nao nam 2014' FROM tSach a LEFT JOIN (SELECT b.MaSach FROM tSach b INNER JOIN tChiTietHDB ON tChiTietHDB.MaSach = b.MaSach INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB WHERE YEAR(NgayBan)
= 2014
) as c ON c.MaSach = a.MaSach WHERE c.MaSach IS NULL

SELECT * FROM SACHKHONGBANDUOC2014

/*
6. Tạo view đưa ra danh sách các sách của NXB Giáo Dục không bán được trong năm 2014.
   [!]Do NXB Giáo Dục không có quyển nào không bán được trong năm 2014 nên lấy NXB Thủ Đô
*/

CREATE VIEW sachKhongBanDuocCuaNXB AS 
SELECT a.MaSach, a.TenSach as 'Ten sach khong ban duoc quyen nao nam 2014 cua NXB Thu Do' FROM tSach a LEFT JOIN (SELECT b.MaSach FROM tSach b INNER JOIN tChiTietHDB ON tChiTietHDB.MaSach = b.MaSach INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB WHERE YEAR(NgayBan)
= 2014
) as c ON c.MaSach = a.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = a.MaNXB WHERE c.MaSach IS NULL AND tNhaXuatBan.TenNXB LIKE  N'NXB Thủ Đô'

SELECT * FROM sachKhongBanDuocCuaNXB

/*
7. Tạo view đưa ra các thông tin về sách và số lượng từng sách được bán ra trong năm 2014.
*/

CREATE VIEW SoLuongSachBanRa2014 AS
SELECT tSach.MaSach, (SELECT TenSach FROM tSach a WHERE a.MaSach = tSach.MaSach) as 'Ten sach', Sum(SLBan) as 'So luong ban nam 2014' FROM tSach INNER JOIN tChiTietHDB ON tChiTietHDB.MaSach = tSach.MaSach INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB WHERE YEAR(NgayBan) = 2014 GROUP BY tSach.MaSach

SELECT * FROM SoLuongSachBanRa2014

/*
8. Tạo view đưa ra họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2014.
*/

CREATE VIEW VIP2014 AS
SELECT tHoaDonBan.SoHDB, (SELECT TenKH FROM tKhachHang a WHERE a.MaKH = (SELECT MaKH FROM tHoaDonBan b WHERE b.SoHDB = tHoaDonBan.SoHDB)) as 'VIP 2014', SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) as 's' FROM tChiTietHDB INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach INNER JOIN tKhachHang ON tKhachHang.MaKH = tHoaDonBan.MaKH WHERE YEAR(NgayBan) = 2014 GROUP BY tHoaDonBan.SoHDB HAVING SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) = (SELECT MAX(d.sum) FROM (SELECT SUM(tChiTietHDB.SLBan*tSach.DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) as 'sum' FROM tChiTietHDB INNER JOIN tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach WHERE YEAR(NgayBan) = 2014 GROUP BY tHoaDonBan.SoHDB) as d
)

SELECT * FROM VIP2014

/*
9.Tạo view đưa ra danh sách 3 nhân viên (MaKH, TenKH) có doanh số cao nhất của năm hiện
tại.
*/

CREATE VIEW BestEmployee AS
SELECT TOP 3 tNhanVien.MaNV, SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) as 'Tong hoa don', (SELECT a.TenNV FROM tNhanVien a WHERE a.MaNV = tNhanVien.MaNV) as 'Ten Nhan Vien' FROM tHoaDonBan INNER JOIN tNhanVien ON tNhanVien.MaNV = tHoaDonBan.MaNV INNER JOIN tChiTietHDB ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach GROUP BY tNhanVien.MaNV ORDER BY SUM(SLBan*DonGiaBan*(CASE WHEN KhuyenMai IS NOT NULL THEN CONVERT(int, KhuyenMai) ELSE 1 END)) DESC 

SELECT * FROM BestEmployee

/*
10. Tạo view đưa ra danh sách sách và số lượng nhập của mỗi nhà xuất bản trong năm hiện tại
*/

CREATE VIEW ImportCurrYear AS
SELECT (SELECT a.TenNXB FROM tNhaXuatBan a WHERE a.MaNXB = tNhaXuatBan.MaNXB) as 'Ten NXB' ,SUM(SLNhap) as 'So luong nhap' FROM tHoaDonNhap INNER JOIN tChiTietHDN ON tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN INNER JOIN tSach ON tSach.MaSach = tChiTietHDN.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = tSach.MaNXB WHERE YEAR(NgayNhap) = 2014 GROUP BY tNhaXuatBan.MaNXB

SELECT * FROM ImportCurrYear


/*====================================================================BAI2======================================================================*/

USE BT3

/*
1. Tạo View danh sách sinh viên, gồm các thông tin sau: Mã sinh viên, Họ sinh viên, Tên sinh
viên, Học bổng.
*/
CREATE VIEW sinhVien AS
SELECT MaSV as 'Ma sinh vien', CONCAT(HoSV,' ',TenSV) as 'Ho va ten', HocBong as 'Hoc Bong' FROM DSSinhVien 

SELECT * FROM sinhVien

/*
2. Tạo view Liệt kê các sinh viên có học bổng từ 150,000 trở lên và sinh ở Hà Nội, gồm các
thông tin: Họ tên sinh viên, Mã khoa, Nơi sinh, Học bổng
*/

CREATE VIEW sinhVien150HN AS
SELECT MaSV as 'Ma sinh vien', CONCAT(HoSV,' ',TenSV) as 'Ho va ten', HocBong as 'Hoc Bong', DSSinhVien.MaKhoa as 'Ma Khoa', DMKhoa.MaKhoa as 'Ten Khoa' FROM DSSinhVien INNER JOIN DMKhoa ON DMKhoa.MaKhoa = DSSinhVien.MaKhoa WHERE HocBong>=150000 AND NoiSinh LIKE N'Hà Nội'

SELECT * FROM sinhVien150HN


/*
3. Tạo view liệt kê những sinh viên nam của khoa Anh văn và khoa tin học, gồm các thông tin:
Mã sinh viên, Họ tên sinh viên, tên khoa, Phái
*/

CREATE VIEW sinhVienAVTH as
SELECT MaSV as 'Ma sinh vien', CONCAT(HoSV,' ',TenSV) as 'Ho va ten', DMKhoa.TenKhoa as 'Ten Khoa', Phai as 'Gioi tinh' FROM DSSinhVien INNER JOIN DMKhoa ON DMKHoa.MaKhoa = DSSinhVien.MaKhoa WHERE (TenKhoa LIKE N'Anh Văn') OR (TenKhoa LIKE N'Tin Học')

SELECT * FROM sinhVienAVTH

/*
4. Tạo view gồm những sinh viên có tuổi từ 20 đến 25, thông tin gồm: Họ tên sinh viên, Tuổi, Tên
khoa.
*/

CREATE VIEW SinhVien2025 AS
SELECT CONCAT(HoSV,' ',TenSV) as 'Ho va ten', DATEDiFF(year,NgaySinh,GETDATE()) as 'Tuoi', DMKHoa.TenKhoa as 'Ten Khoa' FROM DSSinhVien INNER JOIN DMKhoa ON DMKhoa.MaKhoa = DSSinhVien.MaKhoa WHERE  DATEDiFF(year,NgaySinh,GETDATE())>=20 AND  DATEDiFF(year,NgaySinh,GETDATE())<=25

SELECT * FROM SinhVien2025

/*
5. Tạo view cho biết thông tin về mức học bổng của các sinh viên, gồm: Mã sinh viên, Phái,
Mã khoa, Mức học bổng. Trong đó, mức học bổng sẽ hiển thị là “Học bổng cao” nếu giá trị của
field học bổng lớn hơn 500,000 và ngược lại hiển thị là “Mức trung bình”
*/

CREATE VIEW xepLoaiHocBong AS
SELECT MaSV as 'Ma sinh vien', CONCAT(HoSV,' ',TenSV) as 'Ho va ten',Phai as 'Gioi tinh', (CASE WHEN HocBong>=500000 THEN 'Hoc bong cao' ELSE 'Muc trung binh' END) as 'Hoc Bong', DSSinhVien.MaKhoa as 'Ma Khoa' FROM DSSinhVien

SELECT * FROM xepLoaiHocBong

/*
6. Tạo view đưa ra thông tin những sinh viên có học bổng lớn hơn bất kỳ học bổng của sinh viên
học khóa anh văn
*/

CREATE VIEW sinhVienPreferAV as
SELECT MaSV as 'Ma sinh vien', CONCAT(HoSV,' ',TenSV) as 'Ho va ten',Phai as 'Gioi tinh', DMKhoa.MaKhoa as 'Ma Khoa' FROM DSSinhVien INNER JOIN DMKhoa ON DMKhoa.MaKhoa = DSSinhVien.MaKhoa WHERE DMKhoa.MaKhoa NOT LIKE 'AV' AND HocBong > (SELECT MIN(HocBong) FROM DSSinhVien INNER JOIN DMKhoa ON DMKhoa.MaKhoa = DSSinhVien.MaKhoa WHERE DMKHoa.TenKhoa LIKE N'Anh Văn'
)

SELECT * FROM sinhVienPreferAV

/*
7. Tạo view đưa ra thông tin những sinh viên đạt điểm cao nhất trong từng môn.
*/

CREATE VIEW topServer AS
SELECT DMMonHoc.TenMH as 'Ten mon hoc', CONCAT(DSSinhVien.HoSV,' ', DSSinhVien.TenSV) as 'Ho va ten', KetQua.Diem as 'Diem' FROM DMMonHoc INNER JOIN KetQua ON KetQua.MaMH = DMMonHoc.MaMH INNER JOIN DSSinhVien ON DSSinhVien.MaSV = KetQua.MaSV INNER JOIN (SELECT MAX(Diem) as 'Diem', (SELECT b.MaMH FROM DMMonHoc b WHERE b.MaMH = DMMonHoc.MaMH) as 'Ma mon hoc' FROM KetQua INNER JOIN DMMonHoc ON DMMonHoc.MaMH = KetQua.MaMH GROUP BY DMMonHoc.MaMH
) as a ON a.[Ma mon hoc] = DMMonHoc.MaMH WHERE KetQua.Diem = a.Diem

SELECT * FROM topServer

/*
8. Tạo view đưa ra những sinh viên chưa thi môn cơ sở dữ liệu.
*/

CREATE VIEW sinhVienChuaThiCSDL AS
SELECT c.MaSV as 'Ma sinh vien' ,CONCAT(c.TenSV,' ',c.HoSV) as 'Ho va ten' FROM DSSinhVien c LEFT JOIN (SELECT b.MaSV FROM DSSinhVien b INNER JOIN KetQua On KetQua.MaSV = b.MaSV INNER JOIN DMMonHoc ON DMMonHoc.MaMH = KetQua.MaMH WHERE DMMonHoc.TenMH LIKE N'Cơ Sở Dữ Liệu'
) as a ON a.MaSV = c.MaSV WHERE a.MaSV IS NULL

SELECT * FROM sinhVienChuaThiCSDL

-- Danh sách những học sinh đã học CSDL
SELECT * FROM DSSinhVien INNER JOIN KetQua On KetQua.MaSV = DSSinhVien.MaSV INNER JOIN DMMonHoc ON DMMonHoc.MaMH = KetQua.MaMH WHERE DMMonHoc.TenMH LIKE N'Cơ Sở Dữ Liệu'

/*
9. Tạo view đưa ra thông tin những sinh viên không trượt môn nào.
*/

CREATE VIEW aquamon AS
SELECT CONCAT(b.HoSV,' ',b.TenSV) as 'Ho va ten' FROM DSSinhVien b LEFT JOIN (SELECT c.MaSV FROM DSSinhVien c INNER JOIN KetQua ON KetQua.MaSV = c.MaSV WHERE KetQua.Diem <5
) as a ON a.MaSV = b.MaSV WHERE a.MaSV IS NULL

SELECT * FROM aquamon

-- Danh sách bọn thi trượt
SELECT * FROM DSSinhVien INNER JOIN KetQua ON KetQua.MaSV = DSSinhVien.MaSV WHERE KetQua.Diem <5

/*
10. Tạo view danh sách sinh viên không bi rớt môn nào	
*/

CREATE VIEW aquamon AS
SELECT CONCAT(b.HoSV,' ',b.TenSV) as 'Ho va ten' FROM DSSinhVien b LEFT JOIN (SELECT c.MaSV FROM DSSinhVien c INNER JOIN KetQua ON KetQua.MaSV = c.MaSV WHERE KetQua.Diem <5
) as a ON a.MaSV = b.MaSV WHERE a.MaSV IS NULL

/*====================================================================BAI3======================================================================*/
