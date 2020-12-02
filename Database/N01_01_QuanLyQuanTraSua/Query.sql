/*
Tạo View =======================================================================================================================================
*/

/*
2.1.  Tạo view các hóa đơn bán trong ngày hôm nay:
*/

/*	View 01: 
	View các Hoa Don Ban trong ngay hom nay*/
create view View01_HoaDonBanTrongNgay as
select BillId, UserName, PhoneNumber, CodeVoucher, Total,  Payments, TableId, OrderTimeStart, OrderTimeEnd from Bills 
where DAY(OrderTimeStart) = Day(getDate()) and YEAR(OrderTimeStart) = YEAR(GETDATE()) and MONTH(OrderTimeStart) = MONTH(GETDATE())
-----------------------------------------------------------------------------------------------------------------------------------------------
/*	View 02: 
	Top 3 Nhan Vien có số lượng hóa đơn cao nhất tháng vừa qua (nếu số lượng hóa đơn bằng nhau thì sẽ so sánh bằng tổng tiền của các hóa đơn)
*/
create view View02_Top3NhanVien as
select top(3) Bills.UserName, COUNT(BillId) as SoHoaDon, Sum(Total) as Tong  from Staff inner join Bills on Bills.UserName = Staff.UserName 
group by Bills.UserName
order by SoHoaDon, Tong desc
-----------------------------------------------------------------------------------------------------------------------------------------------
/*	View 03:
	Quán sẽ tặng Voucher cho 5 Khách hàng mua nhiều nhất trong tháng trước(Tổng mua >= 500.000) 
	Tạo view xuất ra thông tin của các khách hàng này (PhoneNumber, FullName, TongMuaThangTruoc, TongALL)
*/ 
create view View03_Top5KhacHang as
select Top(5) Bills.PhoneNumber, FullName, SUM(Total) as Tong from Customer inner join Bills on Bills.PhoneNumber = Customer.PhoneNumber
group by Bills.PhoneNumber,FullName
having SUM(Total) >= 500000
order by Tong desc
-----------------------------------------------------------------------------------------------------------------------------------------------
/*	View 04:
	Thống kê tổng tiền các tháng trong năm hiện tại
*/ 
create view View04_ThongKeTongTienHangThang as
SELECT 'TongThu' AS TongThuTheoThang, 
[1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12]
FROM 
(SELECT MONTH(OrderTimeStart) as Thang, Total
FROM Bills) AS BangNguon
PIVOT 
(
 SUM(Total)
 FOR Thang IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])
) AS BangChuyen;


/*
Tạo Procedure =======================================================================================================================================
*/


/*
	Proc
	Tạo thủ tục lấy ra thống kê số  lượng bán trà, topping theo ngày hôm nay (không cần truyền tham số)
*/
create proc proc01_ThongKe as
begin
	select ISNULL(Table1.DrinkId,'') as DrinkID, ISNULL(DrinkName,'') as DrinkName, ISNULL(SLBanD,'') as SLBanDrink, ISNULL(Table2.ToppingId,'') as ToppingId, ISNULL(ToppingName,'') as ToppingName, ISNULL(SLBanT,'') SLBanTopping 
	from (select ROW_NUMBER() OVER (ORDER BY d1.DrinkId) AS [STT], d1.DrinkId, DrinkName, count(d1.DrinkId) as SLBanD from (Bills b1 inner join Items i1 on b1.BillId = i1.BillId)  full join Drinks d1 on d1.DrinkId = i1.DrinkId WHERE DAY(OrderTimeStart) = DAY(GETDATE()) and MONTH(OrderTimeStart) = MONTH(GETDATE()) and YEAR(OrderTimeStart) = YEAR(GETDATE()) group by d1.DrinkId, DrinkName) Table1 
	full join 
	( select ROW_NUMBER() OVER (ORDER BY t2.ToppingId) AS [STT], t2.ToppingId, ToppingName ,count(t2.ToppingId) as SLBanT	from ((Bills b2 inner join Items i2 on b2.BillId = i2.BillId) inner join ItemTopping it2 on it2.ItemId = i2.ItemId) full join Toppings t2 on t2.ToppingId = it2.ToppingId WHERE DAY(OrderTimeStart) = DAY(GETDATE()) and MONTH(OrderTimeStart) = MONTH(GETDATE()) and YEAR(OrderTimeStart) = YEAR(GETDATE()) group by t2.ToppingId,ToppingName ) Table2 on Table1.STT = Table2.STT
end
------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Tạo thủ tục hiển thị các nhân viên đã xuất hóa đơn ngày hôm nay
*/

CREATE PROC staffDay AS
BEGIN
	SELECT * FROM Bills INNER JOIN Staff ON Bills.UserName = Staff.UserName WHERE DAY(Bills.OrderTimeStart) = DAY(GETDATE()) AND MONTH(Bills.OrderTimeStart) = MONTH(GETDATE()) AND YEAR(Bills.OrderTimeStart) = YEAR(GETDATE())  
END


/*
Tạo thủ tục nhập vào id trà in ra danh sách nguyên liệu. số lượng cần để làm thành trà
*/


CREATE PROC teaResource @idTea VARCHAR(10) AS 
BEGIN
	SELECT Resources.ResourceName, Resources.ResourceId FROM Drinks INNER JOIN Drink_Resource ON Drinks.DrinkId = Drink_Resource.DrinkId INNER JOIN Resources ON Resources.ResourceId = Drink_Resource.ResourceId WHERE Drinks.DrinkId = @idTea
END

DECLARE @idTea VARCHAR(10)
SET @idTea = '01'
EXEC dbo.teaResource @idTea

/*
Tạo thủ tục in ra tất cả khả năng trà sữa kết hợp được với topping
*/


CREATE PROC combiTeaTopping AS
BEGIN
	SELECT Drinks.DrinkName,Toppings.ToppingName FROM Drinks INNER JOIN Items ON Items.DrinkId = Drinks.DrinkId INNER JOIN ItemTopping ON ItemTopping.DrinkId = Drinks.DrinkId  FULL OUTER JOIN Toppings ON ItemTopping.ToppingId = Toppings.ToppingId
END

EXEC dbo.combiTeaTopping

/*
Tạo trigger =======================================================================================================================================
*/

/*
. Tạo trigger tự động cập nhật trạng thái bàn khi nhân viên tiến hành đặt hàng (chỉ được 4 người ngồi 1 bàn) :
*/

ALTER TRIGGER updateLevel ON Bills FOR INSERT,UPDATE,DELETE AS
BEGIN
	DECLARE @count int
	SELECT @count = ISNULL(COUNT(Bills.TableId),0) FROM Bills INNER JOIN TableSpace ON Bills.TableId = TableSpace.TableId WHERE Bills.OrderTimeEnd IS NULL GROUP BY TableSpace.TableId HAVING TableSpace.TableId = '1' 

	IF @count>=4
		UPDATE TableSpace SET Status=0 WHERE TableId = (SELECT TableId FROM INSERTED)
	ELSE
		UPDATE TableSpace SET Status=1 WHERE TableId = (SELECT TableId FROM INSERTED)
END

/*
. Tạo trigger tự động cập nhật level cho khách mua hàng khi tiến hành thanh toán thành công (cứ 500000 thì tăng level): 
*/

ALTER TRIGGER updateLevel ON Bills FOR INSERT,UPDATE,DELETE AS
BEGIN
	DECLARE @sum int
	SELECT @sum = SUM(Total) FROM Bills GROUP BY PhoneNumber HAVING PhoneNumber = (SELECT PhoneNumber FROM inserted)

	UPDATE Customer SET Level = @sum/500000 WHERE PhoneNumber = (SELECT PhoneNumber FROM inserted)
END

/*
Tạo trigger cập nhật lại kho khi hóa đơn thanh toán thành công (có sử dụng 2 hàm mô tả ở dưới): [4.3]
*/

ALTER TRIGGER updateResource ON Items FOR INSERT,UPDATE AS
BEGIN
	DECLARE @idBill nvarchar(10) 
	SELECT @idBill = BillId FROM INSERTED 
	UPDATE Resources SET Amount = Amount - ISNULL(dbo.getAmountResourceDrink(ResourceId,@idBill),0)	
	UPDATE Resources SET Amount = Amount - ISNULL(dbo.getAmountResourceTopping(ResourceId,@idBill),0)
END


/*
Tạo trigger thực hiện việc xóa một hóa đơn, thay vì xóa luôn hóa đơn đó, ta sẽ xóa các bảng kết nối với hóa đơn đó trước
*/


CREATE TRIGGER autoDeleteBill ON Bills INSTEAD OF Delete AS
BEGIN
	DECLARE @billId varchar(10)
	SELECT @billId=BillId FROM DELETED

	DELETE ItemTopping WHERE ItemTopping.BillId = @billId
	DELETE Items WHERE Items.BillId = @billId
	DELETE Bills WHERE BillId = @billId
END

/*
Tạo function =======================================================================================================================================
*/

/*
Tạo các hàm trả về số lượng tài nguyên cần dùng để tạo của một mã trà sữa, hoặc topping, phục vụ cho trigger 4.3:
*/

CREATE FUNCTION getAmountResourceTopping(@idResource varchar(10), @idBill varchar(10)) RETURNS INT AS 
BEGIN
	DECLARE @res int
	SELECT @res = ISNULL(Topping_Resource.Amount,0) FROM Items INNER JOIN ItemTopping ON ItemTopping.ItemId = Items.ItemId INNER JOIN Toppings ON Toppings.ToppingId = ItemTopping.ToppingId INNER JOIN Topping_Resource ON Topping_Resource.ToppingId = Toppings.ToppingId INNER JOIN Resources ON Resources.ResourceId = Topping_Resource.ResourceId WHERE Items.BillId = @idBill AND Resources.ResourceId = @idResource
	RETURN @res
END

CREATE FUNCTION getAmountResourceDrink(@idResource varchar(10), @idBill varchar(10)) RETURNS INT AS
BEGIN
	DECLARE @res int
	SELECT @res = ISNULL(Drink_Resource.Amount,0) FROM Bills INNER JOIN Items ON Items.BillId = Bills.BillId INNER JOIN Drink_Resource On Drink_Resource.DrinkId = Items.DrinkId WHERE Items.BillId = @idBill AND Drink_Resource.ResourceId = @idResource
	RETURN @res
END


/*
Tạo hàm kiểm tra xem một nhân viên có quyền Thêm (I), Xóa (D), Sửa (E), Xem (V) trong cơ sở dữ liệu hay không:
*/


CREATE FUNCTION checkPer(@per varchar(1), @userName varchar(10)) RETURNS BIT AS
BEGIN
	DECLARE @res BIT
	DECLARE @id varchar(10)
	SELECT @id = Staff.UserName FROM Staff INNER JOIN UserPermision ON Staff.UserName = UserPermision.UserName INNER JOIN Permision ON Permision.PermisionID = UserPermision.PermisionID INNER JOIN PermisionDetail ON PermisionDetail.PermisionID = Permision.PermisionID WHERE Staff.UserName = @userName AND PermisionDetail.ActionName = @per
	
	IF @id = @userName
		SET @res = 1
	ELSE
		SET @res = 0

	RETURN @res
END
-- Ví dụ
print dbo.checkPer('C','prochicken007')


/*
Tạo hàm đưa ra tổng doanh thu các hóa đơn bán từ ngày bắt đầu đến ngày kết thúc
*/


CREATE FUNCTION billCustom(@start VARCHAR(10), @end VARCHAR(10)) RETURNS INT AS
BEGIN
	DECLARE @startDate DATETIME
	DECLARE @endDate DATETIME
	DECLARE @res INT

	SET @startDate = CONVERT(DATETIME,@start,103)
	SET @endDate = CONVERT(DATETIME,@end,103)

	SELECT @res = SUM(Bills.Total) FROM Bills WHERE Bills.OrderTimeStart>=@startDate AND Bills.OrderTimeStart<=@endDate
	
	RETURN @res
END

print dbo.billCustom('26/11/2020','27/11/2020')


/*
Tạo hàm kiểm tra xem một bàn có những ai đang ngồi
*/

CREATE FUNCTION checkTable(@idTable varchar(10)) RETURNS TABLE AS
RETURN (SELECT Customer.FullName FROM TableSpace INNER JOIN Bills ON Bills.TableId = TableSpace.TableId INNER JOIN Customer ON Customer.PhoneNumber = Bills.PhoneNumber WHERE Bills.OrderTimeEnd IS NULL AND TableSpace.TableId = @idTable
)

/*THANK YOU <3*/







