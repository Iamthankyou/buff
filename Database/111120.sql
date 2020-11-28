USE BT1

/*Tạo trường số lượng nhập tren bảng sách, cập nhật tự động cho trường này cho cả ba hành động cả insert, update, delete*/

ALTER TABLE tSach ADD SLN int

DROP TRIGGER autoUpdateHDN

CREATE TRIGGER autoUpdateHDN ON tChiTietHDN FOR INSERT,UPDATE,DELETE  AS
BEGIN
	UPDATE tSach SET SLN = ISNULL((SELECT SUM(SLNhap) FROM tChiTietHDN GROUP BY MaSach HAVING MaSach = (SELECT MaSach FROM INSERTED)),0) WHERE MaSach = ((SELECT MaSach FROM INSERTED))
	UPDATE tSach SET SLN = ISNULL((SELECT SUM(SLNhap) FROM tChiTietHDN GROUP BY MaSach HAVING MaSach = (SELECT MaSach FROM DELETED)),0) WHERE MaSach = ((SELECT MaSach FROM DELETED))
END

-- Check

INSERT INTO tHoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC) VALUES('HDN07','NV02',GETDATE(),'NCC02')
INSERT INTO tChiTietHDN(SoHDN,MaSach,SLNhap) VALUES('HDN07','S04','5')

UPDATE tChiTietHDN SET SLNhap=100 WHERE SOHDN = 'HDN07'

DELETE tChiTietHDN WHERE SoHDN = 'HDN06'

SELECT MaSach,SUM(SLNhap) FROM tChiTietHDN GROUP BY MaSach 

SELECT SUM(SLNhap) FROM tChiTietHDN GROUP BY MaSach HAVING MaSach = tSach.MaSach

SELECT * FROM tChiTietHDN

UPDATE tChiTietHDN SET SLNhap=15 WHERE SoHDN = 'HDN05'
SELECT * FROM tHoaDonNhap

https://cl.lexax.ru/cr/pr2
https://shopey.ru/

SELECT * FROM tNhaXuatBan

SELECT tNhaXuatBan.MaNXB as 'MaNXB',tChiTietHDB.SoHDB as 'SoHD',SLBan  as 'SL' FROM tChiTietHDB INNER JOIN tHoaDonBan ON tChiTietHDB.SoHDB=tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = tSach.MaNXB WHERE tNhaXuatBan.MaNXB LIKE 'NXB01'
UNION ALL
SELECT tNhaXuatBan.MaNXB as 'MaNXB',tChiTietHDN.SoHDN,SLNhap FROM tChiTietHDN INNER JOIN tHoaDonNhap ON tChiTietHDN.SoHDN=tHoaDonNhap.SoHDN INNER JOIN tSach ON tSach.MaSach = tChiTietHDN.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = tSach.MaNXB WHERE tNhaXuatBan.MaNXB LIKE 'NXB01'

SELECT * FROM (SELECT tNhaXuatBan.MaNXB as 'MaNXB',tChiTietHDB.SoHDB,SLBan FROM tChiTietHDB INNER JOIN tHoaDonBan ON tChiTietHDB.SoHDB=tHoaDonBan.SoHDB INNER JOIN tSach ON tSach.MaSach = tChiTietHDB.MaSach INNER JOIN tNhaXuatBan ON tNhaXuatBan.MaNXB = tSach.MaNXB WHERE tNhaXuatBan.MaNXB LIKE 'NXB01'
) as a INNER 


SELECT * FROM tChiTietHDN

