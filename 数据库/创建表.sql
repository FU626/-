
--创建SC,Student,Course表并插入数据
 
DROP TABLE IF EXISTS SC
DROP TABLE IF EXISTS Student
DROP TABLE IF EXISTS Course
 
CREATE TABLE Student          
 (	
 Sno CHAR(9) PRIMARY KEY,        /* 列级完整性约束条件,Sno是主码*/                  
 Sname CHAR(20) UNIQUE,          /* Sname取唯一值*/
 Ssex CHAR(2),
 Sage SMALLINT,
 Sdept CHAR(20)
 ); 
 
CREATE TABLE  Course
 (	
 Cno CHAR(4) PRIMARY KEY,
 Cname CHAR(40),            
 Cpno CHAR(4),               	                      
 Ccredit SMALLINT,
 FOREIGN KEY (Cpno) REFERENCES  Course(Cno) /* 表级完整性约束条件， Cpno是外码，被参照表是自身*/
 ); 
 
CREATE TABLE  SC
 (
 Sno CHAR(9), 
 Cno CHAR(4),  
 Grade SMALLINT,
 PRIMARY KEY (Sno,Cno),                      /* 主码由两个属性构成，必须作为表级完整性进行定义*/
 FOREIGN KEY (Sno) REFERENCES Student(Sno),  /* 表级完整性约束条件，Sno是外码，被参照表是Student*/
 FOREIGN KEY (Cno)REFERENCES Course(Cno)     /* 表级完整性约束条件，Cno是外码，被参照表是Course*/
 ); 
 
 
INSERT  INTO  Student (Sno,Sname,Ssex,Sdept,Sage) VALUES ('201215121','李勇','男','CS',20);
INSERT  INTO  Student (Sno,Sname,Ssex,Sdept,Sage) VALUES ('201215122','刘晨','女','CS',19);
INSERT  INTO  Student (Sno,Sname,Ssex,Sdept,Sage) VALUES ('201215123','王敏','女','MA',18);
INSERT  INTO  Student (Sno,Sname,Ssex,Sdept,Sage) VALUES ('201215125','张立','男','IS',19);
INSERT  INTO  Student (Sno,Sname,Ssex,Sdept,Sage) VALUES ('201215128','陈冬','男','IS',20);
 
SELECT * FROM Student
 
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('1','数据库',NULL,4);
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('2','数学',NULL,4);
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('3','信息系统',NULL,4);
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('4','操作系统',NULL,4);
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('5','数据结构',NULL,4);
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('6','数据处理',NULL,4);
INSERT  INTO Course(Cno,Cname,Cpno,Ccredit)	VALUES ('7','Pascal语言',NULL,4);
 
UPDATE Course SET Cpno = '5' WHERE Cno = '1' 
UPDATE Course SET Cpno = '1' WHERE Cno = '3' 
UPDATE Course SET Cpno = '6' WHERE Cno = '4' 
UPDATE Course SET Cpno = '7' WHERE Cno = '5' 
UPDATE Course SET Cpno = '6' WHERE Cno = '7' 
 
SELECT * FROM Course
 
INSERT  INTO SC(Sno,Cno,Grade) VALUES ('201215121 ','1',92);
INSERT  INTO SC(Sno,Cno,Grade) VALUES ('201215121 ','2',85);
INSERT  INTO SC(Sno,Cno,Grade) VALUES ('201215121 ','3',88);
INSERT  INTO SC(Sno,Cno,Grade) VALUES ('201215122 ','2',90);
INSERT  INTO SC(Sno,Cno,Grade) VALUES ('201215122 ','3',80);
 
SELECT * FROM SC;

--创建教师表Teacher

CREATE TABLE Teacher
(Tno nchar(10) PRIMARY KEY,
Tname nchar(12),
Tsex nchar(5),
Tdept nchar(5),
Tiden nchar(20),
Tage SMALLINT,
Salary INT
);

--创建用户表SysUser,登录日志Syslog

CREATE TABLE SysUser          
 (	
 UserID NCHAR(20) PRIMARY KEY,                          
 UserPassWord NCHAR(32) ,             
 UserSchoolID NCHAR(20),
 UserMobile NCHAR(11),
 UserBirthday datetime,
 UserIdentity NCHAR(20),
 UserPhoto image
 ); 


 CREATE TABLE SysLog          
 (	
 UserID NCHAR(20) ,                          
 DateAndTime datetime,
 UserOperation NCHAR(200)
 ); 

 --创建表T_C，用来显示教师所教课程

 CREATE TABLE T_C
(Tno NCHAR(10),
Cno CHAR(4),
PRIMARY KEY(Tno,Cno),
FOREIGN KEY (Tno) REFERENCES Teacher(Tno),
FOREIGN KEY (Cno) REFERENCES Course(Cno)
);

--创建表USER_NUM，用来统计每种身份各有多少人

CREATE TABLE USER_NUM
(UserIdentity nchar(20),
number INT
);

INSERT INTO USER_NUM
SELECT DISTINCT UserIdentity,COUNT(*)
FROM SysUser
GROUP BY UserIdentity; --插入数据