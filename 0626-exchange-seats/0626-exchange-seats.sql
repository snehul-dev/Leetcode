# Write your MySQL query statement below
SELECT 
CASE WHEN 
    id % 2 = 1 And id < (select max(id) from Seat)
    THEN id + 1 
    WHEN id % 2 = 0
    THEN id - 1
    else id
    end as id , student
    FROM Seat 
    ORDER BY id ASC;

