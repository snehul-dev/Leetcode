# Write your MySQL query statement below
SELECT employee_id , department_id 
from Employee 
where primary_flag = 'Y' 
or employee_id  in (
    select employee_id from
    Employee 
     GROUP BY employee_id
    HAVING COUNT(*) = 1
)
