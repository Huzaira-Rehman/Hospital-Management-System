USE HospitalDB;
GO


CREATE TABLE Doctors
(
    DoctorID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorName VARCHAR(100),
    Specialization VARCHAR(100),
    Contact VARCHAR(50),
    Status VARCHAR(20)
);


