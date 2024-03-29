USE [master]
GO
/****** Object:  Database [Phonebook]    Script Date: 02/17/2013 21:00:22 ******/
CREATE DATABASE [Phonebook] ON  PRIMARY 
( NAME = N'Phonebook', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Phonebook.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Phonebook_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Phonebook_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Phonebook] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Phonebook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Phonebook] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Phonebook] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Phonebook] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Phonebook] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Phonebook] SET ARITHABORT OFF
GO
ALTER DATABASE [Phonebook] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Phonebook] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Phonebook] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Phonebook] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Phonebook] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Phonebook] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Phonebook] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Phonebook] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Phonebook] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Phonebook] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Phonebook] SET  DISABLE_BROKER
GO
ALTER DATABASE [Phonebook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Phonebook] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Phonebook] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Phonebook] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Phonebook] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Phonebook] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Phonebook] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Phonebook] SET  READ_WRITE
GO
ALTER DATABASE [Phonebook] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Phonebook] SET  MULTI_USER
GO
ALTER DATABASE [Phonebook] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Phonebook] SET DB_CHAINING OFF
GO
USE [Phonebook]
GO
/****** Object:  Table [dbo].[tbPhoneTypes]    Script Date: 02/17/2013 21:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPhoneTypes](
	[PhoneTypeID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbPhoneTypes] PRIMARY KEY CLUSTERED 
(
	[PhoneTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbPhoneTypes] ON
INSERT [dbo].[tbPhoneTypes] ([PhoneTypeID], [PhoneTypeName]) VALUES (1, N'Mobile')
INSERT [dbo].[tbPhoneTypes] ([PhoneTypeID], [PhoneTypeName]) VALUES (2, N'Home')
INSERT [dbo].[tbPhoneTypes] ([PhoneTypeID], [PhoneTypeName]) VALUES (3, N'Work')
SET IDENTITY_INSERT [dbo].[tbPhoneTypes] OFF
/****** Object:  Table [dbo].[tbGroups]    Script Date: 02/17/2013 21:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbGroups](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbGroups] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbGroups] ON
INSERT [dbo].[tbGroups] ([GroupID], [GroupName]) VALUES (1, N'Family')
INSERT [dbo].[tbGroups] ([GroupID], [GroupName]) VALUES (2, N'Work')
INSERT [dbo].[tbGroups] ([GroupID], [GroupName]) VALUES (3, N'Friends')
INSERT [dbo].[tbGroups] ([GroupID], [GroupName]) VALUES (4, N'Other')
SET IDENTITY_INSERT [dbo].[tbGroups] OFF
/****** Object:  Table [dbo].[tbPersons]    Script Date: 02/17/2013 21:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPersons](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[GroupID] [int] NOT NULL,
 CONSTRAINT [PK_tbPersons] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spPhoneTypesDisplay]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<Display the phone types>
-- =============================================
CREATE PROCEDURE [dbo].[spPhoneTypesDisplay] 

AS
BEGIN
	SELECT tpt.PhoneTypeName  FROM tbPhoneTypes tpt
END
GO
/****** Object:  StoredProcedure [dbo].[spGroupsDisplay]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<Display all group>
-- =============================================
CREATE PROCEDURE [dbo].[spGroupsDisplay] 
	AS
BEGIN
	SELECT GroupName FROM tbGroups
END
GO
/****** Object:  Table [dbo].[tbPhones]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPhones](
	[PhoneID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[PhoneTypeID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_tbPhones] PRIMARY KEY CLUSTERED 
(
	[PhoneID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spResetTable]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<Clear all records from tbPerson and start over counting the IDs>
-- =============================================
CREATE PROCEDURE [dbo].[spResetTable]
AS
BEGIN
	DELETE FROM tbPersons
	DBCC CHECKIDENT (tbPersons, RESEED, 0)
	DBCC CHECKIDENT (tbPhones, RESEED, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeletePerson]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<Delete person (using delete cascade)>
-- =============================================
CREATE PROCEDURE [dbo].[spDeletePerson] 
	@personID INT
AS
BEGIN
	DELETE FROM tbPersons
	WHERE PersonID = @personID
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertUpdateContact]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<If contactID = null --> the sp used for Add new contact
--					else --> the sp used for Update a contact>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertUpdateContact]
	@firstName NVARCHAR(50),
	@lastName NVARCHAR(50),
	@groupID INT,
	@personID INT
	
AS
BEGIN
		IF @personID IS NULL
		BEGIN
		INSERT INTO tbPersons
		  (
			-- PersonID -- this column value is auto-generated
			FirstName,
			LastName,
			GroupID
		   )
		   VALUES
		   (
			 @firstName,
			 @lastName,
			 @groupID
		   )
		RETURN @@identity
		END
		ELSE
			BEGIN
				UPDATE tbPersons
				SET
    			FirstName = @firstName,
    			LastName = @lastName,
    			GroupID = @groupID
    	
				WHERE PersonID = @personID
				RETURN @personID
			END

	   
END
GO
/****** Object:  StoredProcedure [dbo].[spLinkPhone]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<If phoneID = null --> the sp used for Add new phone number for contact
--					else --> the sp used for Update a phone number by the phoneID>
-- =============================================
CREATE PROCEDURE [dbo].[spLinkPhone]
	@PersonID INT,
	@phoneNumber NVARCHAR(15),
	@phoneTypeID INT,
	@PhoneID INT
	
AS
BEGIN
	
	IF @PhoneID IS NULL
	BEGIN
		INSERT INTO tbPhones
		(
    		-- PhoneID -- this column value is auto-generated
    		PhoneNumber,
    		PhoneTypeID,
    		PersonID
		)
		VALUES
		(
    		@phoneNumber,
    		@phoneTypeID,
    		@PersonID
		)
	END
	ELSE
	BEGIN
		UPDATE tbPhones
		SET
			-- PhoneID = ? -- this column value is auto-generated
			PhoneNumber = @phoneNumber,
			PhoneTypeID = @phoneTypeID,
			PersonID = @PersonID
		WHERE PhoneID = @PhoneID	
	END
	
    
	
END
GO
/****** Object:  StoredProcedure [dbo].[spDeletePhone]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<Delete a phone number by phoneID>
-- =============================================
CREATE PROCEDURE [dbo].[spDeletePhone]
	@phoneID INT
AS
BEGIN
    DELETE FROM tbPhones
    WHERE PhoneID = @phoneID
    
END
GO
/****** Object:  StoredProcedure [dbo].[spContactsDisplay]    Script Date: 02/17/2013 21:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hofit Politi>
-- Description:	<Show all fields for contacts>
-- =============================================
CREATE PROCEDURE [dbo].[spContactsDisplay]
	AS
BEGIN
	SELECT p.PersonID 'ID', p.FirstName, p.LastName,ph.PhoneID, pt.PhoneTypeName, ph.PhoneNumber, g.GroupName
FROM  dbo.tbPersons AS p LEFT JOIN
               dbo.tbGroups AS g ON g.GroupID = p.GroupID LEFT JOIN
               dbo.tbPhones AS ph ON ph.PersonID = p.PersonID LEFT JOIN
               dbo.tbPhoneTypes AS pt ON pt.PhoneTypeID = ph.PhoneTypeID
END
GO
/****** Object:  ForeignKey [FK_tbPersons_tbGroups]    Script Date: 02/17/2013 21:00:24 ******/
ALTER TABLE [dbo].[tbPersons]  WITH CHECK ADD  CONSTRAINT [FK_tbPersons_tbGroups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbGroups] ([GroupID])
GO
ALTER TABLE [dbo].[tbPersons] CHECK CONSTRAINT [FK_tbPersons_tbGroups]
GO
/****** Object:  ForeignKey [FK_tbPhones_tbPersons]    Script Date: 02/17/2013 21:00:36 ******/
ALTER TABLE [dbo].[tbPhones]  WITH CHECK ADD  CONSTRAINT [FK_tbPhones_tbPersons] FOREIGN KEY([PersonID])
REFERENCES [dbo].[tbPersons] ([PersonID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbPhones] CHECK CONSTRAINT [FK_tbPhones_tbPersons]
GO
/****** Object:  ForeignKey [FK_tbPhones_tbPhoneTypes]    Script Date: 02/17/2013 21:00:36 ******/
ALTER TABLE [dbo].[tbPhones]  WITH CHECK ADD  CONSTRAINT [FK_tbPhones_tbPhoneTypes] FOREIGN KEY([PhoneTypeID])
REFERENCES [dbo].[tbPhoneTypes] ([PhoneTypeID])
GO
ALTER TABLE [dbo].[tbPhones] CHECK CONSTRAINT [FK_tbPhones_tbPhoneTypes]
GO
