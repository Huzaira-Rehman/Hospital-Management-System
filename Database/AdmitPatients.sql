USE HospitalDB;
GO


CREATE TABLE AdmitPatients
(
    AdmitID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT,
    RoomID INT,
    DoctorID INT,
    AdmitDate DATE,
    Status VARCHAR(20)
);

select *from AdmitPatients;