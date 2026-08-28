# Write your MySQL query statement below
SELECT distinct  MAX(salary) as SecondHighestSalary 
from Employee
where  salary < (
     SELECT  distinct  MAX(salary)
     from Employee
)