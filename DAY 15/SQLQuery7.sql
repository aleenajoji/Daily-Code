SELECT  'is registered',CHARINDEX('D','INDIA' ) AS 'Position in string';

select DATEPART(weekday,getdate())

select left(empname,1),count(*) from emp group by left(empname,1);

alter table emp add constraint deptId_fk foreign key(deptId)
reference dept(deptId);