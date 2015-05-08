
CREATE DATABASE [KUAS]
GO

USE [KUAS]
GO

CREATE TABLE [dbo].[Course](
	[CourseID]   [nvarchar](20) NOT NULL,
	[CourseName] [nvarchar](200) NOT NULL,
	[CourseDescription]  [nvarchar](1000) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N's001'  , N'Asp.NET', fffff);
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N's002', N'C#', cccccc);
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (N's003'  , N'雲端程式設計', sssss);
GO
