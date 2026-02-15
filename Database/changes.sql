USE HospitalDB;
GO 

 
ALTER TABLE AdmitPatients
ADD DischargeDate DATE;

UPDATE Rooms
SET Status = 'Available'
WHERE RoomID NOT IN (
    SELECT RoomID 
    FROM AdmitPatients 
    WHERE Status = 'Admitted'
);

UPDATE Doctors
SET Status = 'Available'
WHERE DoctorID NOT IN (
    SELECT DoctorID 
    FROM AdmitPatients 
    WHERE Status='Admitted'

);

 

 
