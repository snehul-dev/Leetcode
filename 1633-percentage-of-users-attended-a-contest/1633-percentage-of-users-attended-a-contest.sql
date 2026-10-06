# Write your MySQL query statement below
SELECT r.contest_id  , ROUND(count(r.user_id)*100 / (SELECT COUNT(*) FROM Users),2) AS percentage 
FROM Register r
group by r.contest_id 
ORDER BY percentage DESC , r.contest_id ASC
 
