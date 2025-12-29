----1. SELECT — Basic Syntax

--SELECT VendorName, Email
--FROM Vendor;

----2. WHERE (Filtering Data)

--SELECT * FROM Vendor
--WHERE Status = 1;


----3. ORDER BY (Sorting)

--SELECT * FROM Vendor
--order by VendorName DESC;

--SELECT * FROM Vendor
--order by VendorName ASC;


----4. DISTINCT (Remove duplicates)

--Select Distinct e-mail from Vendor;

----5. LIMIT / OFFSET

--Select Top 5 * From Vendor;

--SELECT *
--FROM Vendor
--ORDER BY VendorId
--OFFSET 10 ROWS        
--FETCH NEXT 5 ROWS ONLY;  

----6. LIKE (Pattern Search)

----%abc% - Contains ABC
----%a - End with ABC
----a% - Start with ABC
----_n% - Second char need to contain n

--Select * from Vendor 
--where vendorname like '%abc%';

-- --7. IN — Search Multiple Values

-- Select * from Vendor
-- where categoryid in (1,3,5);

----8. BETWEEN — Range Search

--Select * From Vendor
--where date between '20-06-2025' and '23-06-2025';

----9. Aggregation Functions


----MIN, MAX, COUNT, AVG, SUM 

--select Count(*) from Vendor;

--Select AVG(salary) from Vendor;

--Select SUM(salary) from Vendor;

--Select MIN(salary) from Vendor;

--Select MAX(salary) from Vendor;


--Select vendorname, avg(amount) from Vendor group by vendorname;
--Select vendorname, avg(amount) from Vendor group by vendorname having avg(amount) > 1;


--Select st_no from mark where subject = 'DBS' and mark > (Select s_id from mark where s_id = 102 and subject = 'DBS')

----select subject from marks group by students having max(marks);
