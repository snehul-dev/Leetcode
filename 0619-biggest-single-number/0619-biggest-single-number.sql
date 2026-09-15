# Write your MySQL query statement below
SELECT  max(num) as num
from MyNumbers
WHERE num in (
    SELECT num from MyNumbers
    group by num
    having count(*) = 1
)