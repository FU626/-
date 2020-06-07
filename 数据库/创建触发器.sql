IF(OBJECT_ID('regist_recorder') is not null)        -- �ж���Ϊ regist_recorder �Ĵ������Ƿ����
DROP TRIGGER regist_recorder        -- ɾ��������
GO

CREATE TRIGGER regist_recorder
ON SysUser  	         
AFTER
INSERT
AS 
	declare @UserName    nchar(20)
	declare @DateTime    datetime
	declare @UserOperation nchar(200)

	select @UserName = system_user
	select @DateTime = CONVERT(datetime,GETDATE(),120) 

	declare @op varchar(10)
	select @op=case when exists(select 1 from inserted) and exists(select 1 from deleted)
                   then 'Update'
                   when exists(select 1 from inserted) and not exists(select 1 from deleted)
                   then 'Insert'
                   when not exists(select 1 from inserted) and exists(select 1 from deleted)
                   then 'Delete' end
                   
	
	select @UserOperation = @op
	

	INSERT INTO SysLog(UserID,DateAndTime,UserOperation)
	VALUES (@UserName,@DateTime,@UserOperation)

--��ݼ���������ͳ��

IF(OBJECT_ID('User_num_count') is not null)        -- �жϴ������Ƿ����
DROP TRIGGER User_num_count        -- ɾ��������
GO

CREATE TRIGGER User_num_count
ON SysUser
AFTER 
INSERT,DELETE
AS
     UPDATE USER_NUM SET number = 
	 (SELECT COUNT(*) FROM SysUser WHERE UserIdentity = 'Administrator')
	 WHERE UserIdentity = 'Administrator';

	 UPDATE USER_NUM SET number = 
	 (SELECT COUNT(*) FROM SysUser WHERE UserIdentity = 'Teacher')
	 WHERE UserIdentity = 'Teacher';

	 UPDATE USER_NUM SET number = 
	 (SELECT COUNT(*) FROM SysUser WHERE UserIdentity = 'Student')
	 WHERE UserIdentity = 'Student';

	 SELECT * FROM SysLog;

	 delete from SysLog;