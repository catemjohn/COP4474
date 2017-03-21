﻿CREATE TABLE [dbo].[COURSES] (
    [COURSE_ID]    INT            IDENTITY (1, 1) NOT NULL,
    [COURSE_NAME]  NVARCHAR (50)  NULL,
    [DESCRIPTION]  NVARCHAR (250) NULL,
    [PROFESSOR_ID] INT            NULL,
    [COMMENTS]     NVARCHAR (500) NULL,
    [COURSE_NUMBER] NVARCHAR(10) NULL, 
    [CREDITS] INT NULL, 
    [PREREQUISITES] NVARCHAR(150) NULL, 
    PRIMARY KEY CLUSTERED ([COURSE_ID] ASC), 
    CONSTRAINT [FK_COURSES_ToTable] FOREIGN KEY ([PROFESSOR_ID]) REFERENCES [PROFESSOR_INFO]([PROFESSOR_ID])
);

