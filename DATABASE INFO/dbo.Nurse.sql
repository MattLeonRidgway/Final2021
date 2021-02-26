CREATE TABLE [dbo].[Nurse]
(
	[NurseID] INT NOT NULL PRIMARY KEY, 
    [NurseFName] VARCHAR(50) NOT NULL, 
    [NurseMName] VARCHAR(50) NULL, 
    [NurseLName] VARCHAR(50) NOT NULL, 
    [NurseSex] CHAR(10) NOT NULL, 
    [NurseStatus] INT NOT NULL, 
    [NurseType] INT NOT NULL, 
    [NurseDepartment] VARCHAR(50) NOT NULL, 
    [NurseClinic] VARCHAR(50) NOT NULL, 
    [NurseEmail] VARCHAR(50) NOT NULL, 
    [NurseNotes] NCHAR(10) NOT NULL
)
