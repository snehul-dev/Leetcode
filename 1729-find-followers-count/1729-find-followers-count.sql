# Write your MySQL query statement below
SELECT user_id , count(*) as followers_count
from Followers

group by user_id
Order by user_id asc