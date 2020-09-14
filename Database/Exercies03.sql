USE BT2

SELECT * FROM DSHS

ALTER FUNCTION average(@code nvarchar(5)) RETURNS FLOAT AS
BEGIN
	DECLARE @res float
	SELECT @res = (TOAN + LY + HOA + VAN)/4 FROM DIEM WHERE @code = MAHS
	return @res
END 

DROP FUNCTION average

print dbo.average('00732')
