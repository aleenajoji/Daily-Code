select deptId , count(*) from emp group by deptId having/*used when there is 1000 of rows*/ deptId<3;

select * from dept , emp where emp.deptId  = dept.deptId ;   /*cross join or carstion product*/ 
create

/*Inner Join / Join*/
select 'Emp' + emp.EmpName + 'works in' + dept.DeptName + 'Department.'
from dept join emp
on emp.deptId=dept.deptId  /*Emp Ram works in Purchase dept
                             Emp Shyam works in Sales dept*/


/*Outter Join*/




