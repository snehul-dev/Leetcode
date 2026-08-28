# Write your MySQL query statement below
SELECT firstName,lastName ,city,state
from Person p
Left join Address a
on p.personId = a.personId