SELECT Distinct(dogs.name) FROM dogs
UNION
SELECT Distinct(cats.name) FROM cats
