USE HospitalDB;
GO

CREATE TABLE Rooms
(
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNo VARCHAR(20),
    RoomType VARCHAR(50),
    Charges INT,
    Status VARCHAR(20)
); 
