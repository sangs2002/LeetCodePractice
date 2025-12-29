--GO

--IF OBJECT_ID('dbo.Vendor', 'U') IS NOT NULL
--BEGIN
--    -- 1. Add new column
--    ALTER TABLE Vendor 
--    ADD gpaynumber VARCHAR(10) NULL;

--    -- 2. Update default value for existing rows
--    UPDATE Vendor 
--    SET gpaynumber = '9876543210'
--    WHERE gpaynumber IS NULL;

--    -- 3. Make column NOT NULL now that data exists
--    ALTER TABLE Vendor
--    ALTER COLUMN gpaynumber VARCHAR(10) NOT NULL;

--    -- 4. Drop column (if intended)
--    ALTER TABLE Vendor
--    DROP COLUMN gpaynumber;
--END
