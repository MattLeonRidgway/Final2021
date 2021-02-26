CREATE TABLE [dbo].[Doctor]
(
	[DoctorID] INT NOT NULL PRIMARY KEY, 
    [DoctorFName] VARCHAR(50) NOT NULL, 
    [DoctorMName] VARCHAR(50) NULL, 
    [DoctorLName] VARCHAR(50) NOT NULL, 
    [DoctorSex] CHAR(10) NOT NULL, 
    [DoctorStatus] INT NOT NULL, 
    [DoctorType] INT NOT NULL, 
    [DoctorDepartment] VARCHAR(50) NOT NULL, 
    [DoctorClinic] VARCHAR(50) NOT NULL, 
    [DoctorEmail] VARCHAR(50) NOT NULL, 
    [DoctorNotes] NCHAR(10) NOT NULL
)
