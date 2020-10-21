use BT2

SELECT * FROM dbo.DIEM
-- Cau 1
CREATE TRIGGER tgDiem ON dbo.DIEM FOR INSERT,UPDATE AS
BEGIN
	DECLARE @ly int,@toan int, @van int, @hoa int
	SELECT @ly = LY from inserted
	SELECT @toan = TOAN from inserted
	SELECT @hoa = HOA from inserted
	SELECT @van = VAN from inserted

	if ((@ly>10 or @ly<0) or (@hoa>10 or @hoa<0) or (@van>10 or @van<0) or (@toan>10 or @toan<0)) 
		BEGIN
			print('Not rule!')
			rollback transaction
		END
END

DROP TRIGGER tgDIEM

-- Cau 2
CREATE TRIGGER autoUpdate ON dbo.DIEM for INSERT,UPDATE AS
BEGIN
	UPDATE dbo.DIEM
	SET DTB = ((TOAN+VAN)*2+LY+HOA)/6
	FROM dbo.DIEM WHERE MAHS IN (SELECT MAHS FROM INSERTED)
END

DROP TRIGGER autoUpdate

INSERT INTO dbo.DIEM(MAHS,TOAN,LY,HOA,VAN) VALUES('0102',1,1,1,2)

UPDATE dbo.DIEM SET VAN = 10 WHERE MAHS LIKE '0101'

SELECT * FROM dbo.DIEM WHERE MAHS LIKE '0102'

ALTER TABLE dbo.DIEM ADD DTB float(2)

-- Cau 3

ALTER TABLE dbo.DIEM ADD PASS int

SELECT * FROM DIEM

CREATE TRIGGER autoPass1 ON DIEM for UPDATE,INSERT as
BEGIN
	UPDATE DIEM 
		SET PASS = (CASE WHEN DTB>=5 THEN 1 ELSE 0 END)
	FROM DIEM WHERE MAHS IN (SELECT MAHS FROM INSERTED)
END

DROP TRIGGER autoPass1

INSERT INTO dbo.DIEM(MAHS,TOAN,LY,HOA,VAN) VALUES('0103',1,1,1,1)

UPDATE dbo.DIEM SET VAN = 5 WHERE MAHS LIKE '0102'

SELECT * FROM DIEM WHERE MAHS LIKE '0103'

-- Cau 4 

CREATE TRIGGER autoPass2 ON DIEM FOR INSERT,UPDATE AS
BEGIN
	DECLARE @min int,@toan int,@ly int,@hoa int,@van int
	SELECT @toan = TOAN FROM INSERTED
	SELECT @ly = LY FROM INSERTED
	SELECT @hoa = HOA FROM INSERTED
	SELECT @van = VAN FROM INSERTED

	IF (@toan<@ly and @toan<@van and @toan<@hoa)
		BEGIN
			SELECT @min = @toan
		END
	ELSE IF (@hoa<@ly and @hoa<@van and @hoa<@toan)
		BEGIN
			SELECT @min = @hoa
		END
	ELSE IF (@ly<@toan and @ly<@van and @ly<@hoa)
		BEGIN
			SELECT @min = @ly
		END
	ELSE
		BEGIN
			SELECT @min = @van
		END

	/*
	CASE
		WHEN @toan<@ly and @toan<@van and @toan<@hoa THEN @min = @toan
		WHEN @hoa<@ly and @hoa<@van and @hoa<@toan THEN @min = @hoa
		WHEN @ly<@toan and @ly<@van and @ly<@hoa THEN @min = @ly
		ELSE
			@min = @van 
	END
	*/
	UPDATE dbo.DIEM
	SET DTB = ((TOAN+VAN)*2+LY+HOA)/6
	FROM dbo.DIEM WHERE MAHS IN (SELECT MAHS FROM INSERTED)

	UPDATE DIEM 
		SET PASS = (CASE WHEN DTB>=5 and @min>=4 THEN 1 ELSE 0 END)
	FROM DIEM WHERE MAHS IN (SELECT MAHS FROM INSERTED)

END

DROP TRIGGER autoPass2


USE BT2

SELECT * FROM DIEM


CREATE TRIGGER DTN ON Diem ADD DTN float

CREATE TRIGGER diemThapNhat ON DIEM FOR INSERT,UPDATE AS
BEGIN
	DECLARE @dtn float, @toan float, @ly float, @van float, @hoa float
	SELECT @toan = TOAN, @ly = LY, @van = VAN, @hoa = HOA FROM INSERTED 

	SET @dtn = @toan

	IF @dtn>@ly
		SET @dtn = @ly
	IF @dtn>@van
		SET @dtn = @van
	IF @dtn>@hoa
		SET @dtn = @hoa

	UPDATE DIEM SET DTN = @dtn WHERE MAHS  = (SELECT MAHS FROM INSERTED)
END

SELECT * FROM DIEM

UPDATE DIEM SET TOAN = 0 WHERE 




UPDATE dbo.DIEM SET VAN = 10,TOAN=10,HOA=10,LY=4 WHERE MAHS LIKE '0102'

SELECT * FROM DIEM WHERE MAHS LIKE '0102'

-- Cau 5

SELECT * FROM DSHS

DELETE FROM DSHS WHERE MAHS LIKE '00882'

SELECT * FROM DSHS WHERE MAHS LIKE '00882'

SELECT * FROM DIEM WHERE MAHS LIKE '00882'

CREATE TRIGGER autoDelete ON DSHS for DELETE AS
BEGIN
	DELETE FROM DIEM WHERE DIEM.MAHS like (SELECT MAHS FROM DELETED)
END

DROP TRIGGER autoDelete

-- Cau 6 ??
-- Cau 7
CREATE VIEW baocao AS
select a.MAHS,CONCAT(a.Ho,a.TEN) as 'FullName',a.NGAYSINH,(CASE when a.Nu=0 then 'Nam' else 'Nu' end) as 'Sex',(b.HOA+b.Ly+b.TOAN+b.VAN)/4 as 'Diem trung binh'  from dbo.DSHS a inner join dbo.DIEM b on a.MAHS = b.MAHS

SELECT * FROM baocao

-- Cau 8
ALTER TABLE DIEM ADD DTN float(2)

GO
CREATE FUNCTION min4(@toan float, @ly float, @hoa float, @van float) RETURNS FLOAT AS
BEGIN
	DECLARE @min int

	IF (@toan<@ly and @toan<@van and @toan<@hoa)
		BEGIN
			SELECT @min = @toan
		END
	ELSE IF (@hoa<@ly and @hoa<@van and @hoa<@toan)
		BEGIN
			SELECT @min = @hoa
		END
	ELSE IF (@ly<@toan and @ly<@van and @ly<@hoa)
		BEGIN
			SELECT @min = @ly
		END
	ELSE
		BEGIN
			SELECT @min = @van
		END

	RETURN @min
END
GO

-- Show list DSHS code
use BT2

CREATE FUNCTION showList (@codeClass char(5)) RETURNS TABLE AS
	RETURN (SELECT DSHS.HO,DSHS.TEN FROM DSHS INNER JOIN DIEM ON DSHS.MAHS = DIEM.MAHS INNER JOIN LOP ON LOP.LOP = DSHS.LOP WHERE 
	(TOAN+LY+HOA+VAN)/4 >=8 AND LOP.LOP = @codeClass)

-- START
DROP FUNCTION getDTN
DROP FUNCTION getDTB

CREATE FUNCTION getDTN(@code nvarchar(5)) RETURNS FLOAT AS
BEGIN
	DECLARE @toan float, @ly float, @van float, @hoa float, @min float
	SELECT @toan = TOAN, @ly = LY, @van = VAn, @hoa = HOA FROM DIEM WHERE @code = DIEM.MAHS
	SET @min = @toan
	IF (@min>@van)
		SET @min = @van
	IF (@min>@ly)
		SET @min = @ly
	IF (@min>@hoa)
		SET @min = @hoa
	RETURN @min
END

CREATE FUNCTION getDTB(@code nvarchar(5)) RETURNS FLOAT AS
BEGIN
	DECLARE @res float
	SELECT @res = (TOAN+LY+HOA+VAN)/4 FROM DIEM WHERE @code = DIEM.MAHS
	RETURN @res
END

CREATE FUNCTION getRank(@code nvarchar(5)) RETURNS nvarchar(10) AS
BEGIN
	DECLARE @res nvarchar(10)
	DECLARE @dtb float
	SET @dtb = dbo.getDTB(@code)
	
	IF (@dtb>=8)
		SET @res = 'Gioi'
	ELSE IF (@dtb>=6)
		SET @res = 'Kha'
	ELSE
		SET @res = 'Trung Binh'

	RETURN @res
END

CREATE FUNCTION getSex(@code nvarchar(5)) RETURNS nvarchar(10) AS
BEGIN
	DECLARE @x bit
	SELECT @x = NU FROM DSHS WHERE @code = DSHS.MAHS
	DECLARE @res nvarchar(10)

	IF (@x=0)
		SET @res = 'Nu'
	ELSE 
		SET @res = 'Nam'

	RETURN @res
END

DROP FUNCTION showList3

CREATE FUNCTION showList3(@codeClass nvarchar(4)) RETURNS TABLE AS RETURN(
		SELECT dbo.getDTN(DSHS.MAHS) as 'DTN', dbo.getDTB(DSHS.MAHS) as 'DTB', dbo.getRank(DSHS.MAHS) as 'RANK' FROM DSHS WHERE @codeClass = DSHS.LOP
	)

DROP FUNCTION showList4

CREATE FUNCTION showList4(@codeClass nvarchar(4)) RETURNS TABLE AS RETURN (
	SELECT COUNT(DTN) AS 'Num',DTN as 'DTN' FROM dbo.showList3(@codeClass) GROUP BY DTN
)

CREATE FUNCTION showList5(@codeClass nvarchar(4)) RETURNS TABLE AS RETURN (
	SELECT COUNT(DTB) AS 'Num',DTB as 'DTN' FROM dbo.showList3(@codeClass) GROUP BY DTB
)

CREATE FUNCTION showList6(@codeClass nvarchar(4)) RETURNS TABLE AS RETURN (
	SELECT COUNT(RANK) AS 'Num',RANK as 'RANK' FROM dbo.showList3(@codeClass) GROUP BY RANK
)


SELECT * FROM dbo.showList4('10a1') 
SELECT * FROM dbo.showList5('10a1') 
SELECT * FROM dbo.showList6('10a1')

SELECT * FROM dbo.showList6('10a1')

CREATE FUNCTION showList2(@codeClass nvarchar(4)) RETURNS TABLE AS
BEGIN
	RETURN
		(SELECT CONCAT(HO,' ',TEN) as 'FullName', dbo.getDTN(MAHS) as 'MinPoint', dbo.getDTB(MAHS) as 'AVGPoint', dbo.getSex(MAHS) as 'Sex', dbo.getRank(MAHS) as 'Rank' FROM DSHS WHERE LOP = @codeClass)
END

CREATE PROCEDURE updateDTN AS
BEGIN
	UPDATE DIEM 
		SET DTN = dbo.min4(TOAN,HOA,LY,VAN)
	FROM DIEM 	
END

EXEC updateDTN

DROP PROCEDURE updateDTN

SELECT * FROM DIEM

-- Cau 9

CREATE TRIGGER updateDTN2 ON DIEM FOR INSERT,UPDATE AS
BEGIN
	UPDATE DIEM	
		SET DTN = dbo.min4(TOAN,HOA,LY,VAN)
	FROM DIEM WHERE MAHS IN (SELECT MAHS FROM INSERTED)
END

DROP TRIGGER updateDTN2

SELECT * FROM DIEM WHERE MAHS LIKE '00905'

UPDATE DIEM set VAN=1 WHERE MAHS LIKE '00905'

-- Cau 10
CREATE VIEW xuatSac AS
SELECT a.MAHS as 'Code',CONCAT(a.HO,' ',a.TEN) AS 'FullName',a.LOP AS 'class', (CASE WHEN a.NU=0 THEN 'Girl' ELSE 'Boy' END) as 'Sex', b.TOAN as 'Math', b.LY as 'Physical', b.HOA as 'Chemistry', b.VAN 'Literture',b.DTB,b.DTN FROM DSHS a INNER JOIN DIEM b ON a.MAHS = b.MAHS WHERE b.DTB>=8.5 AND b.DTN>=8

SELECT * FROM xuatSac

-- Cau 11
CREATE VIEW topServer AS
SELECT a.MAHS as 'Code',CONCAT(a.HO,' ',a.TEN) AS 'FullName',a.LOP AS 'class', (CASE WHEN a.NU=0 THEN 'Girl' ELSE 'Boy' END) as 'Sex', b.TOAN as 'Math', b.LY as 'Physical', b.HOA as 'Chemistry', b.VAN 'Literture',b.DTB,b.DTN FROM DSHS a INNER JOIN DIEM b ON a.MAHS = b.MAHS WHERE DTB = (SELECT MAX(DTB) FROM DIEM)
	


