/*           proj1                proj2
              101 A               104A 
			  102 A               105C
			  103 D               107R
			  
			  
			  UNION A D C R
			  UNION ALL  A A D A C R
			  EXCEPT     D
			  INTERSECT  A
			  
			                                           */


declare @age int;
declare @firstname char(20),@lastname char(20);
set @lastname=' hloo ';set @firstname=' glolu '; set @age = 20;
print @lastname+@firstname;