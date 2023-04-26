INSERT INTO LOCATIONS (location_id, street_address, postal_code, city)



VALUES ('&location_id', '&street_addr', '&postal_code', '&city');

SELECT ename, sal, (sal + 100)*12 AS annual_compensation FROM emp;

ALTER TABLE EMP MODIFY (phno VARCHAR2(7));

UPDATE EMP SET phno = '2' || phno;

