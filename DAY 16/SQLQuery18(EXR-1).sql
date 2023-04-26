select * from countries;

select * from departments;

select * from employees;

select * from JOBS_HISTORY;

select * from jobs;

select * from locations;

select * from regions;

-----Q.4-----


select first_name, salary, 12*salary+100 as 'monthly salary plus a monthly bonus of $100, multiplied by

12' from employees;

-----Q.5-----


UPDATE EMPLOYEES SET phone_number = CONCAT('2', phone_number); 


-----Q.6-----


/*DELETE employee_id , salary, job_id FROM employees WHERE dept_id = 502;*/



/* ANS: When using the DELETE statement to delete data from a table, we should only specify the table name

and the WHERE clause that identifies the rows to be deleted. You should not include the column names in the DELETE statement.

The correct syntax would be: DELETE FROM employees WHERE dept_id = 90;

*/


-----Q.7-----



SELECT COUNT(DISTINCT department_id)

FROM employees

WHERE last_name = 'Smith';

-----Q.8-----



SELECT first_name, last_name, hire_date HIREDATE, salary

FROM EMPLOYEES

ORDER BY hire_date;

-----Q.9-----



create table student_grades(

student_id NUMERIC(12),

semester_end date,

gpa NUMERIC(4,3));

INSERT INTO student_grades VALUES

(101,'12-05-2022',9.6),

(102,'03-04-2022',7.6),

(103,'09-08-2022',8.8);

SELECT * FROM student_grades;

SELECT STUDENT_ID, GPA

FROM STUDENT_GRADES

ORDER BY GPA DESC;

----Q.10----



SELECT first_name, job_id, salary

FROM employees

LEFT OUTER JOIN departments

ON employees.department_id = departments.department_id

WHERE departments.department_id IS NULL;

-----Q.11-----



create table customers(

customer_id numeric(4) not null,

customer_name varchar(100) not null,

customer_address varchar(150),

customer_phone varchar(20));

insert into customers values

(101,'GANGA','HANI',9876867545),

(102,'FINI','JAYANAGAR',9087655554),

(103,'Daya','Karthika',7089765645);

select * from customers;

select 'Dear customer ' + customer_name + ', ' from customers;

-----Q.12-----



CREATE TABLE emp (

 id INT,

 name VARCHAR(50),

 sal DECIMAL(10,2),

 comm_pct DECIMAL(3,2),

 pf DECIMAL(10,2),

 hra DECIMAL(10,2),

 tearn DECIMAL(10,2),

 tded DECIMAL(10,2),

 net DECIMAL(10,2)

);

INSERT INTO emp (id, name, sal, comm_pct) VALUES

(1, 'John', 50000, 0.05),

(2, 'Jane', 60000, 0.10),

(3, 'Bob', 75000, 0.08);

select * from emp;

UPDATE emp

SET pf = sal * 0.1,

  hra = sal * 0.12,

  tearn = sal + (sal * 0.12),

  tded = (sal * 0.1) + (sal * 0.04),

  net = sal + (sal * 0.12) - ((sal * 0.1) + (sal * 0.04));













































