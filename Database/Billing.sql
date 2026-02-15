USE HospitalDB;
GO

CREATE TABLE Billing
(
    BillID INT IDENTITY(1,1) PRIMARY KEY,
    AdmitID INT,
    PatientName VARCHAR(100),
    DoctorName VARCHAR(100),
    RoomCharges INT,
    DoctorCharges INT,
    TotalAmount INT,
    BillDate DATE
);




