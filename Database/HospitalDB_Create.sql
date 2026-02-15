CREATE DATABASE HospitalDB;
GO
USE HospitalDB;

CREATE TABLE Users 
(
    UserID INT IDENTITY PRIMARY KEY,
    Username VARCHAR(50),
    Password VARCHAR(50)
);
INSERT INTO Users VALUES ('Huzaira', '7860');

 
