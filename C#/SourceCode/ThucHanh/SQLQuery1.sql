USE BanHang

SELECT * FROM tblUser

SELECT * FROM tblHang

ALTER TABLE tblHang ADD URL nvarchar(200)

INSERT INTO tblHang(MaHang,TenHang,ChatLieu,SoLuong,DonGiaNhap,DonGiaBan,URL) VALUES('001','Sua chua','Sua',10,100,120,'\Images\img01.jpg')
INSERT INTO tblHang(MaHang,TenHang,ChatLieu,SoLuong,DonGiaNhap,DonGiaBan,URL) VALUES('002','Kem oc que','Kem',19,10,100,'\Images\img02.jpg')
INSERT INTO tblHang(MaHang,TenHang,ChatLieu,SoLuong,DonGiaNhap,DonGiaBan,URL) VALUES('003','Dau nanh','Dau',20,10,102,'\Images\img03.jpg')
INSERT INTO tblHang(MaHang,TenHang,ChatLieu,SoLuong,DonGiaNhap,DonGiaBan,URL) VALUES('004','Dau nanh','Dau',20,10,102,'\Images\img03.jpg')

