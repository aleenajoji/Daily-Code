DECLARE @t INT=1
SELECT CASE WHEN @t>0 THEN
CASE
WHEN @t=1 THEN 'One'
WHEN @t=2 THEN 'Two'
ELSE 'not a Number required' END
ELSE 'less than one' END

DECLARE @counter INT
SET @counter=1
WHILE @counter <= 10
BEGIN
PRINT @counter
SET @counter=@counter+1
ENd