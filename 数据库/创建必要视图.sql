
--������ͼ

--ѧ���γ����ͳɼ�
CREATE VIEW STU_Grade
AS 
SELECT Sno,SC.Cno,Cname,Ccredit,Grade
FROM SC,Course
WHERE SC.Cno = Course.Cno;

--ƽ���ɼ���ͼ

CREATE VIEW AVG_Grade(Cno,avg_grade)
AS
SELECT Cno,AVG(Grade)
FROM STU_Grade
GROUP BY Cno;

select * from AVG_Grade;


SELECT * FROM STU_Grade;

--�γ̺�ѧ��������ͼ

DROP VIEW C_NUM;
CREATE VIEW C_NUM(Cno,stunum)
AS
SELECT Cno,COUNT(*)
FROM SC
GROUP BY Cno;


select * from C_NUM;

--��ʦ���̿γ̶�Ӧѧ������

CREATE VIEW T_C_NUM
AS
SELECT T_C.Tno,Tname,T_C.Cno,Cname,stunum
FROM T_C,Teacher,Course,C_NUM
WHERE T_C.Tno = Teacher.Tno AND T_C.Cno = Course.Cno AND T_C.Cno = C_NUM.Cno;

SELECT * FROM T_C_NUM;
SELECT * FROM T_C;