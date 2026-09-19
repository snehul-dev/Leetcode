# Write your MySQL query statement below
SELECT score,
DENSE_RANK() OVER(order by score desc)  AS `rank`
from Scores