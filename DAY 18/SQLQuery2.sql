CREATE TRIGGER EMPLOYEE_ID ON EMPLOYEES
AFTER INSERT 
AS
SELECT 'ROW CREATED'

INSERT INTO EMPLOYEES(EMPLOYEE_ID,first_name,last_name)
VALUES(603,'ANAKHA','RAJI')

CREATE TRIGGER EMP_TRIGGERDEL ON EMPLOYEES
AFTER DELETE
AS
SELECT 'ROW DELETED';

DELETE FROM EMPLOYEES WHERE EMPLOYEE_ID=603;