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
6. Thiết lập hàm có đầu vào là số xe, đầu ra là thông tin về lộ trình*/