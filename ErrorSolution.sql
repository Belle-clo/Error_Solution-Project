USE [master]
GO
/****** Object:  Database [ErrorProjectDB]    Script Date: 2023/01/04 14:02:37 ******/
CREATE DATABASE [ErrorProjectDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ErrorProjectDB', FILENAME = N'C:\Program Files\DB\ErrorProjectDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ErrorProjectDB_log', FILENAME = N'C:\Program Files\DB\ErrorProjectDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ErrorProjectDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ErrorProjectDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ErrorProjectDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ErrorProjectDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ErrorProjectDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ErrorProjectDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ErrorProjectDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ErrorProjectDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ErrorProjectDB] SET  MULTI_USER 
GO
ALTER DATABASE [ErrorProjectDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ErrorProjectDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ErrorProjectDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ErrorProjectDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ErrorProjectDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ErrorProjectDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ErrorProjectDB] SET QUERY_STORE = OFF
GO
USE [ErrorProjectDB]
GO
/****** Object:  Table [dbo].[tblError]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblError](
	[ErrorID] [int] IDENTITY(1,1) NOT NULL,
	[ErrorDescription] [nvarchar](50) NOT NULL,
	[ModuleID] [int] NOT NULL,
	[YearID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[ProgLanguageID] [int] NOT NULL,
	[ErrorStatus] [nvarchar](50) NOT NULL,
	[TopicID] [int] NOT NULL,
	[ErrorDate] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblError] PRIMARY KEY CLUSTERED 
(
	[ErrorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblErrorSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblErrorSolution](
	[ErrorSolutionID] [int] IDENTITY(1,1) NOT NULL,
	[ErrorID] [int] NOT NULL,
	[SolutionID] [int] NOT NULL,
	[SolutionDate] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblErrorSolution] PRIMARY KEY CLUSTERED 
(
	[ErrorSolutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblModule](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleDescription] [nvarchar](50) NOT NULL,
	[YearID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProgLanguage]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProgLanguage](
	[ProgLanguageID] [int] IDENTITY(1,1) NOT NULL,
	[ProgLanguageDesc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblProgLanguage] PRIMARY KEY CLUSTERED 
(
	[ProgLanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRole](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblRole] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSolution](
	[SolutionID] [int] IDENTITY(1,1) NOT NULL,
	[SolutionDescription] [nvarchar](50) NOT NULL,
	[LecturerID] [int] NOT NULL,
 CONSTRAINT [PK_tblSolution] PRIMARY KEY CLUSTERED 
(
	[SolutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTimetable]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTimetable](
	[TimetableID] [int] IDENTITY(1,1) NOT NULL,
	[OfficeDescription] [nvarchar](50) NOT NULL,
	[Day] [nvarchar](50) NOT NULL,
	[Time] [nvarchar](50) NOT NULL,
	[YearID] [int] NOT NULL,
	[ModuleID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTopic]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTopic](
	[TopicID] [int] IDENTITY(1,1) NOT NULL,
	[TopicDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTopic] PRIMARY KEY CLUSTERED 
(
	[TopicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTopicModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTopicModule](
	[TopicModuleID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleID] [int] NOT NULL,
	[TopicID] [int] NOT NULL,
 CONSTRAINT [PK_tblTopicModule] PRIMARY KEY CLUSTERED 
(
	[TopicModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[UserStatus] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYear]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYear](
	[YearID] [int] IDENTITY(1,1) NOT NULL,
	[YearDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblYear] PRIMARY KEY CLUSTERED 
(
	[YearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblError]  WITH CHECK ADD  CONSTRAINT [FK_tblError_tblProgLanguage] FOREIGN KEY([ProgLanguageID])
REFERENCES [dbo].[tblProgLanguage] ([ProgLanguageID])
GO
ALTER TABLE [dbo].[tblError] CHECK CONSTRAINT [FK_tblError_tblProgLanguage]
GO
ALTER TABLE [dbo].[tblError]  WITH CHECK ADD  CONSTRAINT [FK_tblError_tblTopic] FOREIGN KEY([TopicID])
REFERENCES [dbo].[tblTopic] ([TopicID])
GO
ALTER TABLE [dbo].[tblError] CHECK CONSTRAINT [FK_tblError_tblTopic]
GO
ALTER TABLE [dbo].[tblError]  WITH CHECK ADD  CONSTRAINT [FK_tblError_tblUser] FOREIGN KEY([StudentID])
REFERENCES [dbo].[tblUser] ([UserID])
GO
ALTER TABLE [dbo].[tblError] CHECK CONSTRAINT [FK_tblError_tblUser]
GO
ALTER TABLE [dbo].[tblErrorSolution]  WITH CHECK ADD  CONSTRAINT [FK_tblErrorSolution_tblError] FOREIGN KEY([ErrorID])
REFERENCES [dbo].[tblError] ([ErrorID])
GO
ALTER TABLE [dbo].[tblErrorSolution] CHECK CONSTRAINT [FK_tblErrorSolution_tblError]
GO
ALTER TABLE [dbo].[tblErrorSolution]  WITH CHECK ADD  CONSTRAINT [FK_tblErrorSolution_tblSolution] FOREIGN KEY([SolutionID])
REFERENCES [dbo].[tblSolution] ([SolutionID])
GO
ALTER TABLE [dbo].[tblErrorSolution] CHECK CONSTRAINT [FK_tblErrorSolution_tblSolution]
GO
ALTER TABLE [dbo].[tblSolution]  WITH CHECK ADD  CONSTRAINT [FK_tblSolution_tblUser] FOREIGN KEY([LecturerID])
REFERENCES [dbo].[tblUser] ([UserID])
GO
ALTER TABLE [dbo].[tblSolution] CHECK CONSTRAINT [FK_tblSolution_tblUser]
GO
ALTER TABLE [dbo].[tblTimetable]  WITH CHECK ADD  CONSTRAINT [FK_tblTimetable_tblYear] FOREIGN KEY([YearID])
REFERENCES [dbo].[tblYear] ([YearID])
GO
ALTER TABLE [dbo].[tblTimetable] CHECK CONSTRAINT [FK_tblTimetable_tblYear]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[tblRole] ([RoleID])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblRole]
GO
/****** Object:  StoredProcedure [dbo].[sp_DelectStudent]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DelectStudent]
	@ErrorID int
AS
BEGIN
	DELETE FROM tblError
	WHERE ErrorID = @ErrorID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteError]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteError]
	@ErrorID int
AS
BEGIN
	DELETE FROM tblError
	WHERE ErrorID = @ErrorID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteErrorSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[sp_DeleteErrorSolution]
	-- Add the parameters for the stored procedure here
	@ErrorSolutionID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblErrorSolution
	WHERE ErrorSolutionID=@ErrorSolutionID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteModule]
	-- Add the parameters for the stored procedure here
	@ModuleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblModule
	WHERE ModuleID=@ModuleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteModuleTopic]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteModuleTopic]
@ModuleTopicID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblTopicModule
	WHERE TopicModuleID = @ModuleTopicID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteProgLang]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteProgLang]
	-- Add the parameters for the stored procedure here
	@ProgLanguageID int
AS  
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblProgLanguage
WHERE ProgLanguageID=@ProgLanguageID 

END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteSolution]
	-- Add the parameters for the stored procedure here
	@SolutionID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblSolution
	WHERE SolutionID=@SolutionID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteTime]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteTime] 
	-- Add the parameters for the stored procedure here
	@TimetableID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblTimetable
	WHERE TimetableID=@TimetableID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteUser]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteUser]
	@UserID int
AS
BEGIN
	DELETE FROM tblUser
	WHERE UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteYearOfStudy]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteYearOfStudy]
	-- Add the parameters for the stored procedure here
	@YearID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblYear 
	WHERE YearID = @YearID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCmbSoltuionName]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCmbSoltuionName] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblUser
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetError]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetError]

AS
BEGIN
	SELECT (Username +' '+ Surname) AS [User Name], ErrorDescription AS [Error Description],StudentID,ProgLanguageID
	FROM tblUser U, tblError E
	WHERE U.UserID = E.StudentID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetErrorcmb]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetErrorcmb]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblError
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetErrorSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetErrorSolution]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblSolution
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetErrorSolutionDgv]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetErrorSolutionDgv]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ErrorSolutionID, SolutionDescription AS [Solution Description],ErrorDescription AS [Error Description],SolutionDate AS [Solution Date]
	FROM tblError,tblSolution,tblErrorSolution
	WHERE tblErrorSolution.ErrorID=tblError.ErrorID
	AND tblSolution.SolutionID=tblErrorSolution.SolutionID
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLecturer]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetLecturer]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID ,Username + ' '+Surname AS Name 
	FROM tblUser u,tblRole r
	WHERE u.RoleID =r.RoleID
	AND RoleDescription ='Lecturer'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLogin]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetLogin]
	@Email nvarchar (50),
	@Password nvarchar (50)
AS
BEGIN
	SELECT * 
	FROM tblUser U, tblRole R
	WHERE U.RoleID = U.RoleID AND Email = @Email AND Password = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetModule]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblModule
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetModuleDgv]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetModuleDgv] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ModuleID, ModuleDescription,YearDescription
	FROM tblModule M,tblYear Y
	WHERE M.YearID=Y.YearID

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Getname]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Getname]
	
AS
BEGIN
	SELECT (Username + ' ' +  Surname) AS Name
	FROM tblRole R, tblUser U
	WHERE R.RoleID = U.RoleID AND R.RoleID = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProgLanguage]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetProgLanguage] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblProgLanguage
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetRoleDescription]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetRoleDescription]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  RoleID,RoleDescription
	FROM tblRole
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetSolutionDgv]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetSolutionDgv]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SolutionID ,Username+ ' '+Surname AS Name,SolutionDescription
	FROM tblUser u,tblSolution s
	WHERE u.UserID = s.LecturerID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStudent]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetStudent]
	
AS
BEGIN
	SELECT ErrorID,(Username +' '+ Surname) AS [User Name], ErrorDescription AS [Error Description], ProgLanguageDesc AS [Programming Language], ModuleDescription, YearDescription AS Year,TopicDescription AS [Topic Description], ErrorDate AS [Error Date], ErrorStatus AS Status 
	FROM tblUser U, tblError E,tblProgLanguage P, tblModule M, tblYear Y,tblTopic T
	WHERE U.UserID = E.StudentID AND E.ProgLanguageID = P.ProgLanguageID AND E.ModuleID = M.ModuleID AND E.YearID = Y.YearID AND E.TopicID = T.TopicID;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStudentName]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetStudentName] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID ,Username + ' '+Surname AS Name 
	FROM tblUser u,tblRole r
	WHERE u.RoleID =r.RoleID 
	AND RoleDescription='Student'
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTimeTableDgv]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetTimeTableDgv]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TimetableID, ModuleDescription AS [Module Description],YearDescription AS [Year Description],Day,Time,OfficeDescription
	FROM tblTimetable t,tblYear y,tblModule m
	WHERE t.YearID = y.YearID and t.ModuleID = m.ModuleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTopicDgv]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetTopicDgv]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TopicID ,TopicDescription
	FROM tblTopic
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTopicModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetTopicModule]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TopicModuleID, ModuleDescription,TopicDescription
	FROM tblTopic t, tblModule m, tblTopicModule tm
	WHERE t.TopicID = tm.TopicID
	AND m.ModuleID = tm.ModuleID
  
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUser]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetUser]
	
AS
BEGIN
	SELECT UserID AS [User ID], Username AS [User Name], Surname, Email, RoleDescription AS [ Role Description], UserStatus AS [Status]
	FROM tblUser, tblRole
	WHERE tblRole.RoleID = tblUser.RoleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUsername]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetUsername]
	
AS
BEGIN
	SELECT UserID, (Username +''+ Surname) AS USERNAME
	FROM tblUser
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetYear]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetYear] 
	
AS
BEGIN
	SELECT YearID, YearDescription AS [Study Year]
	FROM tblYear
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetYearOfStudy]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetYearOfStudy] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblYear
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertErrorSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertErrorSolution]
	-- Add the parameters for the stored procedure here
	@ErrorID int,
	@SolutionID int,
	@SolutionDate nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblErrorSolution (ErrorID,SolutionID,SolutionDate)
	VALUES (@ErrorID,@SolutionID,@SolutionDate)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertModule]
	-- Add the parameters for the stored procedure here
	@ModuleDescription nvarchar(50),
	@YearID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblModule (ModuleDescription,YearID)
	VALUES(@ModuleDescription,@YearID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertModuleTopic]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertModuleTopic]
-- Add the parameters for the stored procedure here
	
	@ModuleID int,
	@TopicID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblTopicModule(ModuleID ,TopicID )
    VALUES (@ModuleID, @TopicID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProgLanguage]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertProgLanguage]  
	-- Add the parameters for the stored procedure here
@ProgLanguageDesc nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

		    -- Insert statements for procedure here
INSERT INTO tblProgLanguage (ProgLanguageDesc)
 VALUES ( @ProgLanguageDesc)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRoleDescription]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertRoleDescription]
	-- Add the parameters for the stored procedure here
	@RoleDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblRole (RoleDescription)
	VALUES (@RoleDescription)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertSolution]
	-- Add the parameters for the stored procedure here
	@SolutionDescription nvarchar(50),
	@LecturerID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblSolution (SolutionDescription,LecturerID)
	VALUES(@SolutionDescription,@LecturerID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertStudent]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertStudent]
	@StudentID int,
	@ErrorDescription nvarchar (50),
	@ModuleID int,
	@ProgLanguageID int,
	@YearID int,
	@ErrorStatus nvarchar (50),
	@ErrorDate nvarchar(50),
	@TopicID int
AS
BEGIN
	INSERT INTO tblError (StudentID, ErrorDescription, ProgLanguageID, ModuleID, YearID,TopicID,ErrorDate, ErrorStatus)
	VALUES (@StudentID, @ErrorDescription, @ProgLanguageID, @ModuleID,@YearID,@TopicID,@ErrorDate, @ErrorStatus )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertTopicDesription]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertTopicDesription]
	-- Add the parameters for the stored procedure here
	@TopicDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblTopic (TopicDescription)
	VALUES(@TopicDescription)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUser]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertUser]
	@RoleID int,
	@Username nvarchar (50),
	@Surname nvarchar (50),
	@Email nvarchar (50),
	@Password nvarchar (50),
	@UserStatus  nvarchar (50)
AS
BEGIN
	INSERT INTO tblUser (RoleID,Username,Surname, Email, Password, UserStatus)
	VALUES (@RoleID, @Username,@Surname, @Email, @Password, @UserStatus)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertYearOfStudy]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertYearOfStudy]
    
	@YearDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblYear ( YearDescription)
	VALUES ( @YearDescription)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Search]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Search]
	-- Add the parameters for the stored procedure here
	@Searchterm nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Username ,Surname ,Email,RoleDescription 
	FROM tblUser u,tblRole r
	WHERE u.RoleID =r.RoleID 
	AND ( UserID Like @Searchterm OR Username Like @Searchterm Or Surname Like @Searchterm Or Email Like @Searchterm )
	GROUP BY Username,Surname,Email,RoleDescription
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchError]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_SearchError]
	-- Add the parameters for the stored procedure here
	@Searchterm nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ErrorDescription,SolutionDescription,SolutionDate
	FROM tblError,tblSolution,tblErrorSolution
	WHERE tblErrorSolution.ErrorID=tblError.ErrorID
	AND tblSolution.SolutionID=tblErrorSolution.SolutionID
	AND (SolutionDescription Like @Searchterm Or ErrorDescription Like @Searchterm OR SolutionDate Like @Searchterm)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchErrorProg]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_SearchErrorProg]
	-- Add the parameters for the stored procedure here
	@Searchterm nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ErrorDescription as [Error Description],ModuleDescription as [Module Description],ProgLanguageDesc as [Programming Language ] ,YearDescription as [Year Description] ,ErrorStatus as [Error Status]
	FROM tblError E,tblModule M,tblProgLanguage P,tblYear Y
	WHERE  E.ProgLanguageID = P.ProgLanguageID AND E.ModuleID = M.ModuleID AND E.YearID = Y.YearID 
	AND (ErrorDescription Like @Searchterm Or ProgLanguageDesc Like @Searchterm Or YearDescription Like @Searchterm Or ErrorStatus Like @Searchterm )
	GROUP BY ErrorDescription,ModuleDescription,ProgLanguageDesc,YearDescription,ErrorStatus
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchErrorTopic]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_SearchErrorTopic] 
	-- Add the parameters for the stored procedure here
	@Searchterm nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure hereTopicID
	SELECT  ErrorDescription, TopicDescription, ErrorDate
	FROM tblError E,tblTopic T
	WHERE E.TopicID = T.TopicID AND (ErrorDescription Like @Searchterm OR TopicDescription Like @Searchterm)
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SeletRole]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_SeletRole]
	
AS
BEGIN
	SELECT *
	FROM tblRole
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimeTable]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_TimeTable]
	-- Add the parameters for the stored procedure here
	
	@OfficeDescription nvarchar(50),
	@Day nvarchar(50),
	@Time nvarchar(50),
	@YearID int,
	@ModuleID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblTimetable (OfficeDescription,Day,Time,YearID,ModuleID)
	VALUES (@OfficeDescription,@Day,@Time,@YearID,@ModuleID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateError]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateError]
	@ErrorDescription nvarchar (50),
	@ErrorID int
AS
BEGIN
	UPDATE tblError SET ErrorDescription = @ErrorDescription
	WHERE ErrorID = @ErrorID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateErrorSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateErrorSolution]
	-- Add the parameters for the stored procedure here
	@ErrorSolutionID int,
	@ErrorID int,
	@SolutionID int,
	@SolutionDate nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblErrorSolution SET ErrorID=@ErrorID,SolutionID=@SolutionID,SolutionDate=@SolutionDate
	WHERE ErrorSolutionID=@ErrorSolutionID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateModule]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateModule] 
	-- Add the parameters for the stored procedure here
	@ModuleID int,
	@YearID int,
	@ModuleDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblModule SET ModuleDescription=@ModuleDescription,YearID=@YearID
	WHERE ModuleID=@ModuleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateModuleTopic]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateModuleTopic]
	-- Add the parameters for the stored procedure here
	@TopicModuleID int,
	@ModuleID int,
	@TopicID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblTopicModule SET ModuleID = @ModuleID, TopicID = @TopicID
	WHERE TopicModuleID = @TopicModuleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProgLanguage]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[sp_UpdateProgLanguage]
	-- Add the parameters for the stored procedure here
@ProgLanguageID int,
@ProgLanguageDesc nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblProgLanguage SET ProgLanguageDesc=@ProgLanguageDesc
WHERE ProgLanguageID=@ProgLanguageID

END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRoleDescription]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateRoleDescription]
	-- Add the parameters for the stored procedure here
	@RoleDescription nvarchar(50),
	@RoleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblRole SET RoleDescription=@RoleDescription
	WHERE RoleID=@RoleID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSolution]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateSolution]
	-- Add the parameters for the stored procedure here
	@SolutionID int,
	@LecturerID int, 
	@SolutionDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblSolution SET SolutionDescription=@SolutionDescription,LecturerID=@LecturerID
	WHERE SolutionID=@SolutionID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStudent]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateStudent]
	@ErrorID int,
	@ErrorDescription nvarchar (50),
	@ModuleID  int,
	@YearID  int,
	@StudentID int,
	@ProgLanguageID int,
	@ErrorStatus nvarchar (50),
	@TopicID int,
	@ErrorDate nvarchar
AS
BEGIN
	UPDATE tblError SET ErrorDescription = @ErrorDescription, ModuleID = @ModuleID ,YearID = @YearID , StudentID = @StudentID, ProgLanguageID = @ProgLanguageID,TopicID=@TopicID,ErrorDate=@ErrorDate, ErrorStatus = @ErrorStatus
	WHERE ErrorID = @ErrorID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTimetable]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateTimetable] 
	-- Add the parameters for the stored procedure here
	@TimetableID int,
	@OfficeDescription nvarchar(50),
	@Day nvarchar(50),
	@Time nvarchar(50),
	@YearID int,
	@ModuleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblTimetable SET OfficeDescription = @OfficeDescription, ModuleID = @ModuleID ,YearID = @YearID , Day=@Day,Time=@Time
	WHERE TimetableID = @TimetableID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTopic]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateTopic] 
	-- Add the parameters for the stored procedure here
	@TopicDescription nvarchar(50),
	@TopicID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblTopic SET TopicDescription=@TopicDescription
	WHERE TopicID=@TopicID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUser]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateUser]
	@Username nvarchar (50),
	@Surname nvarchar (50),
	@Email nvarchar (50),
	@Password nvarchar (50),
	@UserStatus nvarchar (50),
	@UserID int
AS
BEGIN
	UPDATE tblUser SET  Username = @Username, Surname = @Surname, Email = @Email, Password = @Password, UserStatus = @UserStatus
	WHERE UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateYearOfStudy]    Script Date: 2023/01/04 14:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE[dbo].[sp_UpdateYearOfStudy] 
	@YearID int,
	@YearDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblYear SET YearDescription = @YearDescription
	WHERE YearID = @YearID
END
GO
USE [master]
GO
ALTER DATABASE [ErrorProjectDB] SET  READ_WRITE 
GO
