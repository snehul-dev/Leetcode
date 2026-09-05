# Write your MySQL query statement below
SELECT name , bonus from Employee e
Left join Bonus b
ON b. empId = e. empId
where bonus < 1000 OR bonus is null