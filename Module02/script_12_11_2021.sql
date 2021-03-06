USE [master]
GO
/****** Object:  Database [AppClassScheduling]    Script Date: 11/12/2021 1:26:24 PM ******/
CREATE DATABASE [AppClassScheduling]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppClassScheduling', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AppClassScheduling.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppClassScheduling_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AppClassScheduling_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AppClassScheduling] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppClassScheduling].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppClassScheduling] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppClassScheduling] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppClassScheduling] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppClassScheduling] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppClassScheduling] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppClassScheduling] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AppClassScheduling] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppClassScheduling] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppClassScheduling] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppClassScheduling] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppClassScheduling] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppClassScheduling] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppClassScheduling] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppClassScheduling] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppClassScheduling] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AppClassScheduling] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppClassScheduling] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppClassScheduling] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppClassScheduling] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppClassScheduling] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppClassScheduling] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppClassScheduling] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppClassScheduling] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AppClassScheduling] SET  MULTI_USER 
GO
ALTER DATABASE [AppClassScheduling] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppClassScheduling] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppClassScheduling] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppClassScheduling] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppClassScheduling] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppClassScheduling] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AppClassScheduling] SET QUERY_STORE = OFF
GO
USE [AppClassScheduling]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL,
	[ModuleId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[TimeslotId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[GroupId] [int] NOT NULL,
	[GroupSize] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [char](32) NOT NULL,
	[Username] [varchar](32) NOT NULL,
	[Password] [varbinary](64) NOT NULL,
	[Email] [varchar](32) NOT NULL,
	[Gender] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberInRole]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberInRole](
	[MemberId] [char](32) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Module]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Module](
	[ModuleId] [int] NOT NULL,
	[ModuleCode] [varchar](4) NOT NULL,
	[ModuleName] [nvarchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ModuleCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModuleGroup]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleGroup](
	[ModuleId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ModuleId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModuleProfessor]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleProfessor](
	[ModuleId] [int] NOT NULL,
	[ProfessorId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ModuleId] ASC,
	[ProfessorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Professor_Id] [int] NOT NULL,
	[Professor_Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Professor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [uniqueidentifier] NOT NULL,
	[RoleName] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [nvarchar](16) NOT NULL,
	[Capacity] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Timeslot]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timeslot](
	[TimeslotId] [int] NOT NULL,
	[Weekday] [nvarchar](100) NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
 CONSTRAINT [PK_Timeslot] PRIMARY KEY CLUSTERED 
(
	[TimeslotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MemberInRole] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Role] ADD  DEFAULT (newid()) FOR [RoleId]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([ModuleId])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professor] ([Professor_Id])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([TimeslotId])
REFERENCES [dbo].[Timeslot] ([TimeslotId])
GO
ALTER TABLE [dbo].[MemberInRole]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[MemberInRole]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[ModuleGroup]  WITH NOCHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
GO
ALTER TABLE [dbo].[ModuleGroup]  WITH NOCHECK ADD FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([ModuleId])
GO
ALTER TABLE [dbo].[ModuleProfessor]  WITH CHECK ADD FOREIGN KEY([ModuleId])
REFERENCES [dbo].[Module] ([ModuleId])
GO
ALTER TABLE [dbo].[ModuleProfessor]  WITH CHECK ADD FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professor] ([Professor_Id])
GO
/****** Object:  StoredProcedure [dbo].[GetProfessorsByMoudleId]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetProfessorsByMoudleId](@Id int)
as

Select * from Professor join ModuleProfessor
on Professor.Professor_Id = ModuleProfessor.ProfessorId
and ModuleId = @Id;
GO
/****** Object:  StoredProcedure [dbo].[GetProfessorsChecked]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetProfessorsChecked](@Id int)
as
	select Professor.*, CAST(IIF(ModuleId is null,0,1)as bit) Checked from Professor
	left join ModuleProfessor
	on Professor.Professor_Id = ModuleProfessor.ProfessorId
	and ModuleId = @Id;
GO
/****** Object:  StoredProcedure [dbo].[GetProfessorsNotInMoudle]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetProfessorsNotInMoudle](@Id int)
as
select * from Professor where Professor_Id not in 
	(select ProfessorId from ModuleProfessor where  ModuleId = @Id);
GO
/****** Object:  StoredProcedure [dbo].[GetRolesByMember]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetRolesByMember](@Id char(32))
as
	select Role.*, cast(iif(MemberId is null,0,1) as bit) as Checked from  [Role] left join MemberInRole
	on [Role].RoleId = MemberInRole.RoleId
	and MemberId = @Id and IsDeleted=0;
GO
/****** Object:  StoredProcedure [dbo].[GetRolesByMemberId]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetRolesByMemberId](@Id char(32))
as
	select Role.* from Role join MemberInRole on Role.RoleId = MemberInRole.RoleId
	where MemberId =@Id and IsDeleted=0;
GO
/****** Object:  StoredProcedure [dbo].[SaveMemberInRole]    Script Date: 11/12/2021 1:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SaveMemberInRole](@MemberId char(32), @RoleId uniqueidentifier)
as
	begin
		if	exists(select * from MemberInRole where MemberId=@MemberId and RoleId =@RoleId)
			update MemberInRole set IsDeleted =~IsDeleted  where MemberId = @MemberId and RoleId =@RoleId;
		else 
			insert into MemberInRole (MemberId,RoleId) values (@MemberId,@RoleId);
	end
GO
USE [master]
GO
ALTER DATABASE [AppClassScheduling] SET  READ_WRITE 
GO
