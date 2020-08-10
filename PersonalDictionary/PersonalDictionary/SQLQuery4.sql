


CREATE PROC Login_Select
	@user NVARCHAR(50),
	@pass NVARCHAR(50)
AS

SELECT [username]
      ,[password]
  FROM [dbo].[Login]

WHERE @user=[username]
	AND	@pass=[password]

	UPDATE Login
 SET password='admin'
 WHERE password=NULL;
 
 ALTER TABLE Login
 ADD permission INT ;

 