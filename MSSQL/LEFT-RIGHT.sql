// do not need to use substring functon
//LEFT 
//RIGHT


SELECT DISTINCT CITY FROM STATION (NOLOCK)
 WHERE LEFT(CITY, 1) IN ('a','e','i','o','u')
 AND RIGHT(CITY, 1) IN ('a','e','i','o','u')
