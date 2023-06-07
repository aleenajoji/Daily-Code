USE [JWTAuthentication]

CREATE TABLE [dbo].[UserInfo](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [varchar](60) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED
	(
		[UserId] ASC
	)
)
INSERT [dbo].[UserInfo] VALUES (N'Amit Mohanty', N'Admin', N'admin@abc.com', N'$admin@2022', CAST(N'2022-01-17 14:47:58.207' AS DateTime))


CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] NOT NULL,
	[NationalIDNumber] [nvarchar](15) NOT NULL,
	[EmployeeName] [nvarchar](100) NULL,
	[LoginID] [nvarchar](256) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[MaritalStatus] [nchar](1) NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[HireDate] [date] NOT NULL,
	[VacationHours] [smallint] NOT NULL,
	[SickLeaveHours] [smallint] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED
	(
		[EmployeeID] ASC
	)
)
INSERT [dbo].[Employee] VALUES (1, N'295847284', N'Michael Westover', N'adventure-works\ken0', N'Vice President of Sales', CAST(N'1969-01-29' AS Date), N'S', N'M', CAST(N'2009-01-14' AS Date), 99, 69, N'f01251e5-96a3-448d-981e-0f99d789110d', CAST(N'2014-06-30 00:00:00.000' AS DateTime))
INSERT [dbo].[Employee] VALUES (2, N'245797967', N'Raeann Santos', N'adventure-works\terri0', N'Vice President of Engineering', CAST(N'1971-08-01' AS Date), N'S', N'F', CAST(N'2008-01-31' AS Date), 1, 20, N'45e8f437-670d-4409-93cb-f9424a40d6ee', CAST(N'2014-06-30 00:00:00.000' AS DateTime))
INSERT [dbo].[Employee] VALUES (3, N'509647174', N'Pamela Wambsgans', N'adventure-works\roberto0', N'Engineering Manager', CAST(N'1974-11-12' AS Date), N'M', N'M', CAST(N'2007-11-11' AS Date), 2, 21, N'9bbbfb2c-efbb-4217-9ab7-f97689328841', CAST(N'2014-06-30 00:00:00.000' AS DateTime))