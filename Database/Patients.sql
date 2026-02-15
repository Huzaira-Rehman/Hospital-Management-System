USE HospitalDB;
GO

CREATE TABLE Patients
(
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Gender VARCHAR(20),
    Contact VARCHAR(50),
    Address VARCHAR(200),
    Disease VARCHAR(100)
);
GO
