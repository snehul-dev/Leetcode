# Write your MySQL query statement below
SELECT sp.name
from SalesPerson sp

where sales_id not in (
     select o.sales_id 
     from Orders o
     join Company c
     on c.com_id = o.com_id
     where c.name = 'RED'
)