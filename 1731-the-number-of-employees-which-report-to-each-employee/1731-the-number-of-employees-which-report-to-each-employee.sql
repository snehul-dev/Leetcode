# Write your MySQL query statement below
SELECT e.employee_id ,e.name, count(m.employee_id ) as reports_count , ROUND(AVG(m.age)) as average_age 
from Employees e
 join Employees m
on e.employee_id  = m.reports_to 
group by e.employee_id ,e.name
order by e.employee_id