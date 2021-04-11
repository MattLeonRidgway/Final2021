-- Script Date: 4/11/2021 3:56 PM  - ErikEJ.SqlCeScripting version 3.5.2.87
-- Database information:
-- Database: C:\Users\scoob\OneDrive - Champlain College\Current courses\SDEV 360-81 C#\code\Final2021\PatientLite.db
-- ServerVersion: 3.32.1
-- DatabaseSize: 100 KB
-- Created: 2/5/2021 4:04 PM

-- User Table information:
-- Number of tables: 10
-- Clinic: -1 row(s)
-- Department: -1 row(s)
-- Doctor: -1 row(s)
-- DoctorType: -1 row(s)
-- Nurse: -1 row(s)
-- NurseType: -1 row(s)
-- ReviewedDoctor: -1 row(s)
-- ReviewedNurse: -1 row(s)
-- SaveReview: -1 row(s)
-- Status: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [Status] (
  [StatusID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [StatusType] nvarchar(100) NOT NULL COLLATE NOCASE
);
CREATE TABLE [SaveReview] (
  [SavedID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [SavedReviewed] nvarchar(250) NOT NULL COLLATE NOCASE
, [SavedDoctor] int NOT NULL
, [SavedNurse] int NOT NULL
, [SavedDate] nvarchar(150) NOT NULL COLLATE NOCASE
);
CREATE TABLE [ReviewedNurse] (
  [ReviewedID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ReviewedNurseID] int NOT NULL
, [ReviewedDepartment] int NOT NULL
, [ReviewedByNurseID] int NOT NULL
, [ReviewedNurseType] int NOT NULL
);
CREATE TABLE [ReviewedDoctor] (
  [ReviewedID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ReviewedDoctorID] int NOT NULL
, [ReviewedDepartment] int NOT NULL
, [ReviewedByDoctorID] int NOT NULL
);
CREATE TABLE [NurseType] (
  [TypeID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Type] nvarchar(100) NOT NULL COLLATE NOCASE
);
CREATE TABLE [Nurse] (
  [NurseID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [NurseFName] nvarchar(100) NOT NULL COLLATE NOCASE
, [NurseMName] nvarchar(100) NULL COLLATE NOCASE
, [NurseLName] nvarchar(100) NOT NULL COLLATE NOCASE
, [NurseStatus] int NOT NULL
, [NurseType] int NOT NULL
, [NurseDepartment] int NOT NULL
, [NurseClinic] int NOT NULL
, [NurseEmail] nvarchar(100) NOT NULL COLLATE NOCASE
, [NurseNotes] nvarchar(100) NULL COLLATE NOCASE
);
CREATE TABLE [DoctorType] (
  [TypeID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Type] nvarchar(100) NOT NULL COLLATE NOCASE
);
CREATE TABLE [Doctor] (
  [DoctorID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [DoctorFName] nvarchar(100) NOT NULL COLLATE NOCASE
, [DoctorMName] nvarchar(100) NULL COLLATE NOCASE
, [DoctorLName] nvarchar(100) NOT NULL COLLATE NOCASE
, [DoctorStatus] int NOT NULL
, [DoctorType] int NOT NULL
, [DoctorDepartment] int NOT NULL
, [DoctorClinic] int NOT NULL
, [DoctorEmail] nvarchar(100) NOT NULL COLLATE NOCASE
, [DoctorNotes] nvarchar(100) NULL COLLATE NOCASE
);
CREATE TABLE [Department] (
  [DepartmentID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Department] nvarchar(100) NOT NULL COLLATE NOCASE
);
CREATE TABLE [Clinic] (
  [ClinicID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Clinic] nvarchar(100) NOT NULL COLLATE NOCASE
);
INSERT INTO [Status] ([StatusID],[StatusType]) VALUES (
1,'Active');
INSERT INTO [ReviewedNurse] ([ReviewedID],[ReviewedNurseID],[ReviewedDepartment],[ReviewedByNurseID],[ReviewedNurseType]) VALUES (
3,1,1,2,1);
INSERT INTO [ReviewedNurse] ([ReviewedID],[ReviewedNurseID],[ReviewedDepartment],[ReviewedByNurseID],[ReviewedNurseType]) VALUES (
4,2,1,1,1);
INSERT INTO [NurseType] ([TypeID],[Type]) VALUES (
1,'Nurse');
INSERT INTO [NurseType] ([TypeID],[Type]) VALUES (
2,'RN');
INSERT INTO [NurseType] ([TypeID],[Type]) VALUES (
3,'CN');
INSERT INTO [Nurse] ([NurseID],[NurseFName],[NurseMName],[NurseLName],[NurseStatus],[NurseType],[NurseDepartment],[NurseClinic],[NurseEmail],[NurseNotes]) VALUES (
1,'fsdaa','asdf','fdsa',1,1,1,1,'jasdklfgj@gmail.com','asdf');
INSERT INTO [Nurse] ([NurseID],[NurseFName],[NurseMName],[NurseLName],[NurseStatus],[NurseType],[NurseDepartment],[NurseClinic],[NurseEmail],[NurseNotes]) VALUES (
2,'b','n','w',1,1,1,1,'delfikjd@gmail.com','sadfg');
INSERT INTO [DoctorType] ([TypeID],[Type]) VALUES (
1,'Prime');
INSERT INTO [Doctor] ([DoctorID],[DoctorFName],[DoctorMName],[DoctorLName],[DoctorStatus],[DoctorType],[DoctorDepartment],[DoctorClinic],[DoctorEmail],[DoctorNotes]) VALUES (
1,'wer','rew','wre',1,1,1,1,'1@email.com','notes');
INSERT INTO [Doctor] ([DoctorID],[DoctorFName],[DoctorMName],[DoctorLName],[DoctorStatus],[DoctorType],[DoctorDepartment],[DoctorClinic],[DoctorEmail],[DoctorNotes]) VALUES (
2,'uyt','tyu','yut',1,1,1,1,'2@email.com','notes');
INSERT INTO [Doctor] ([DoctorID],[DoctorFName],[DoctorMName],[DoctorLName],[DoctorStatus],[DoctorType],[DoctorDepartment],[DoctorClinic],[DoctorEmail],[DoctorNotes]) VALUES (
3,'matt','ta','well',1,1,1,1,'mat@email.com','notres');
INSERT INTO [Doctor] ([DoctorID],[DoctorFName],[DoctorMName],[DoctorLName],[DoctorStatus],[DoctorType],[DoctorDepartment],[DoctorClinic],[DoctorEmail],[DoctorNotes]) VALUES (
4,'obi','dobi','dog',1,1,1,1,'dog@email.com','Notes');
INSERT INTO [Doctor] ([DoctorID],[DoctorFName],[DoctorMName],[DoctorLName],[DoctorStatus],[DoctorType],[DoctorDepartment],[DoctorClinic],[DoctorEmail],[DoctorNotes]) VALUES (
5,'Skippy','Dippy','Doo',1,1,1,1,'dooDog@email.com','no');
INSERT INTO [Doctor] ([DoctorID],[DoctorFName],[DoctorMName],[DoctorLName],[DoctorStatus],[DoctorType],[DoctorDepartment],[DoctorClinic],[DoctorEmail],[DoctorNotes]) VALUES (
6,'Dianne','e','d',1,1,1,1,'ded@email.com','no');
INSERT INTO [Department] ([DepartmentID],[Department]) VALUES (
1,'Primary Care');
INSERT INTO [Clinic] ([ClinicID],[Clinic]) VALUES (
1,'Antelope');
COMMIT;

