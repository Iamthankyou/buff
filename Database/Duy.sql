use DIEM
-- Cau 1
ALTER TABLE DSHS ADD ghichu nvarchar(100)

SELECT * FROM DSHS WHERE MAHS LIKE '00724'

CREATE PROC updateNote(@msv nvarchar(5)) AS
BEGIN
	 UPDATE dbo.DSHS SET ghichu = 'Chuyen truong tu ngay 5/9/2016' WHERE MAHS = @msv
END

DROP PROCEDURE updateNote

EXEC updateNote '00724'
-- Cau 2
CREATE PROC numClass(@code nvarchar(4),@numClass int output) AS
BEGIN
	SELECT @numClass = COUNT(MAHS) FROM DSHS WHERE @code = LOP
END

DECLARE @res int
EXEC numClass '10A5',@res output
print @res

-- Cau 3

CREATE 

CREATE PROC rankStudent(@code nvarchar(5),@s nvarchar(10) output) AS
BEGIN
	DECLARE @avg float
	SELECT @avg = (TOAN+LY+HOA+VAN)/4 FROM DIEM WHERE MAHS = @code
	
	IF (@avg < 5)
		SET @s = 'Xuat sac'
	ELSE IF (@avg<8)
		SET @s = 'Trung binh'
	ELSE IF (@avg<9)
		SET @s = 'Yeu'
	ELSE 
		SET @s = 'Kem'
END

DROP PROC rankStudent

DECLARE @ss nvarchar(10)
EXEC rankStudent '00724',@ss output
print @ss
 
-- Cau 4
SELECT * FROM DSHS

CREATE PROC exInfor(@code nvarchar(5), @nameClass nvarchar(4) output, @nameTeacher nvarchar(25) output) AS
BEGIN
	SELECT @nameClass = LOP.LOP, @nameTeacher = GVCN FROM DSHS INNER JOIN LOP ON DSHS.LOP = LOP.LOP
END

DECLARE @class nvarchar(5)
DECLARE @teacher nvarchar(25)
EXEC exInfor '00724',@class output, @teacher output
print @class
print @teacher