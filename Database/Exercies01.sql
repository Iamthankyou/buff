use BT2

SELECT * FROM dbo.DIEM



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

INSERT INTO dbo.DIEM(MAHS,TOAN,LY,HOA,VAN) VALUES('0101',1,1,11,1)

SELECT * FROM dbo.DIEM WHERE MAHS LIKE '0101'
