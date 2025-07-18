USE [master]
GO
/****** Object:  Database [AppointmentSystem]    Script Date: 12/6/2024 6:49:12 PM ******/
CREATE DATABASE [AppointmentSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppointmentSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\AppointmentSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppointmentSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\AppointmentSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AppointmentSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppointmentSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppointmentSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppointmentSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppointmentSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppointmentSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppointmentSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppointmentSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppointmentSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppointmentSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppointmentSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppointmentSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppointmentSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppointmentSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppointmentSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppointmentSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppointmentSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppointmentSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppointmentSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppointmentSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppointmentSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppointmentSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppointmentSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppointmentSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppointmentSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AppointmentSystem] SET  MULTI_USER 
GO
ALTER DATABASE [AppointmentSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppointmentSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppointmentSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppointmentSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppointmentSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppointmentSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AppointmentSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [AppointmentSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AppointmentSystem]
GO
/****** Object:  Table [dbo].[appointments]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointments](
	[appointment_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [int] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[appointment_date] [date] NOT NULL,
	[appointment_time] [time](0) NOT NULL,
	[appointment_room] [nvarchar](10) NOT NULL,
	[appointment_description] [nvarchar](100) NULL,
	[appointment_status] [int] NOT NULL,
 CONSTRAINT [PK_appointment] PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctors]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctors](
	[doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_name] [varchar](100) NOT NULL,
	[doctor_specialization] [int] NOT NULL,
	[doctor_email] [nvarchar](50) NOT NULL,
	[doctor_phone] [nvarchar](20) NULL,
	[doctor_room] [nvarchar](10) NOT NULL,
	[doctor_status] [int] NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[images]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[images](
	[doctor_id] [int] NOT NULL,
	[image_doctor] [image] NOT NULL,
 CONSTRAINT [PK_images] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[patient_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_name] [varchar](100) NOT NULL,
	[patient_email] [nvarchar](50) NOT NULL,
	[patient_phone] [nvarchar](20) NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specializations]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specializations](
	[specialization_id] [int] IDENTITY(1,1) NOT NULL,
	[specialization_name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_specializations] PRIMARY KEY CLUSTERED 
(
	[specialization_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](100) NOT NULL,
	[uname] [nvarchar](50) NOT NULL,
	[upass] [nvarchar](max) NOT NULL,
	[user_role] [int] NOT NULL,
	[user_status] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[appointments] ADD  CONSTRAINT [DF_appointment_appointment_status]  DEFAULT ((1)) FOR [appointment_status]
GO
ALTER TABLE [dbo].[doctors] ADD  CONSTRAINT [DF_doctor_doctor_status]  DEFAULT ((1)) FOR [doctor_status]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_user_status]  DEFAULT ((1)) FOR [user_status]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddAppointment]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddAppointment]
    @PatientID				int,
    @DoctorID				int,
    @AppointmentDate		date,
    @AppointmentTime		time(0),
    @AppointmentDescription nvarchar(100)
AS
BEGIN
    INSERT INTO appointments (patient_id, doctor_id, appointment_date, appointment_time, appointment_room, appointment_description)
    SELECT 
        @PatientID, 
        @DoctorID, 
        @AppointmentDate, 
        @AppointmentTime, 
        doctor_room, 
        @AppointmentDescription
    FROM 
        doctors
    WHERE 
        doctor_id = @DoctorID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddDoctor]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddDoctor]
    @DoctorName				nvarchar(100),
    @DoctorSpecialization	int,
    @DoctorEmail			nvarchar(50),
    @DoctorPhone			nvarchar(20),
    @DoctorRoom				nvarchar(10)
AS
BEGIN
    INSERT INTO doctors (doctor_name, doctor_specialization, doctor_email, doctor_phone, doctor_room)
    VALUES (@DoctorName, @DoctorSpecialization, @DoctorEmail, @DoctorPhone, @DoctorRoom)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddPatient]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddPatient]
    @PatientName	nvarchar(100),
    @PatientEmail	nvarchar(50),
    @PatientPhone	nvarchar(20)
AS
BEGIN
    INSERT INTO patients (patient_name, patient_email, patient_phone)
    VALUES (@PatientName, @PatientEmail, @PatientPhone)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddSpecialization]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddSpecialization]
    @SpecializationName varchar(20)
AS
BEGIN
    INSERT INTO specializations (specialization_name)
    VALUES (@SpecializationName)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddUser]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddUser]
    @UserName	nvarchar(100),
    @Uname		nvarchar(50),
    @Upass		nvarchar(MAX),
    @UserRole	int
AS
BEGIN
    INSERT INTO users (user_name, uname, upass, user_role)
    VALUES (@UserName, @UName, @UPass, @UserRole)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_AppointmentList]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AppointmentList]
AS
BEGIN
    SELECT 
		a.appointment_id AS AppointmentID,
		CAST(a.appointment_id AS nvarchar(10)) + CAST(p.patient_id AS nvarchar(10)) + CAST(d.doctor_id AS nvarchar(10)) + a.appointment_room AS AppointmentCode,
        a.patient_id AS PatientID,
		p.patient_name AS PatientName,
		a.doctor_id AS DoctorID,
        d.doctor_name AS DoctorName,
        a.appointment_date AS AppointmentDate,
        a.appointment_time AS AppointmentTime,
        a.appointment_room AS AppointmentRoom,
        a.appointment_description AS AppointmentDescription,
		a.appointment_status AS AppointmentStatus,
        CASE a.appointment_status
            WHEN 0 THEN 'Canceled'
            WHEN 1 THEN 'Scheduled'
			WHEN 2 THEN 'Completed'
        END AS AppointmentStatusStr
    FROM 
		appointments a
    JOIN 
		patients p 
	ON 
		a.patient_id = p.patient_id
    JOIN 
		doctors d 
	ON 
		a.doctor_id = d.doctor_id
	ORDER BY
		a.appointment_date
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteDoctor]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteDoctor]
    @DoctorID int
AS
BEGIN
    UPDATE 
		doctors
    SET 
		doctor_status = 0
    WHERE
		doctor_id = @DoctorID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteSpecialization]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteSpecialization]
    @SpecializationID int
AS
BEGIN
    DELETE FROM 
		specializations
    WHERE 
		specialization_id = @SpecializationID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteUser]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteUser]
    @UserID int
AS
BEGIN
    UPDATE 
		users
    SET 
		user_status = 0
    WHERE
		user_id = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DoctorImageDetail]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DoctorImageDetail]
	@DoctorID int
AS
BEGIN
    SELECT
		image_doctor AS DoctorImage
	FROM
		images
	WHERE
		doctor_id = @DoctorID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DoctorImageInsert]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DoctorImageInsert]
	@DoctorID		int,
	@DoctorImage	image
AS
BEGIN
    DECLARE @total int

	SELECT
		@total = COUNT(*)
	FROM
		images
	WHERE
		doctor_id > 0

	IF @total > 0
		UPDATE images SET image_doctor = @DoctorImage WHERE doctor_id = @DoctorID
	ELSE
		INSERT INTO images VALUES (@DoctorID,@DoctorImage)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DoctorList]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DoctorList]
AS
BEGIN
    SELECT 
		d.doctor_id AS DoctorID, 
        d.doctor_name AS DoctorName, 
		s.specialization_id AS Specialization,
        s.specialization_name AS SpecializationStr, 
        d.doctor_email AS DoctorEmail, 
        d.doctor_phone AS DoctorPhone, 
        d.doctor_room AS DoctorRoom, 
		d.doctor_status AS DoctorStatus,
        CASE d.doctor_status
			WHEN 0 THEN 'Not Active'
			WHEN 1 THEN 'Active'
		END AS DoctorStatusStr
    FROM 
		doctors d
    LEFT JOIN 
		specializations s 
	ON 
		d.doctor_specialization = s.specialization_id
	WHERE
		doctor_status = 1
	ORDER BY
		specialization_id
END
GO
/****** Object:  StoredProcedure [dbo].[usp_PatientList]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_PatientList]
AS
BEGIN
    SELECT
		patient_id AS PatientID, 
		patient_name AS PatientName,
		patient_email AS PatientEmail,
		patient_phone AS PatientPhone
    FROM 
		patients
END
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecializationList]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_SpecializationList]
AS
BEGIN
    SELECT 
		specialization_id AS SpecializationID, 
		specialization_name AS SpecializationName
    FROM 
		specializations
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateAppointment]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateAppointment]
    @AppointmentID			int,
    @PatientID				int,
    @DoctorID				int,
    @AppointmentDate		date,
    @AppointmentTime		time(0),
    @AppointmentRoom		nvarchar(10),
    @AppointmentDescription nvarchar(100),
	@AppointmentStatus		int
AS
BEGIN
    UPDATE 
		appointments
    SET 
		patient_id = @PatientID,
        doctor_id = @DoctorID,
        appointment_date = @AppointmentDate,
        appointment_time = @AppointmentTime,
        appointment_room = @AppointmentRoom,
        appointment_description = @AppointmentDescription,
		appointment_status = @AppointmentStatus
    WHERE 
		appointment_id = @AppointmentID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateDoctor]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateDoctor]
    @DoctorID int,
    @DoctorName nvarchar(100),
    @DoctorSpecialization int,
    @DoctorEmail nvarchar(50),
    @DoctorPhone nvarchar(20),
    @DoctorRoom nvarchar(10)
AS
BEGIN
    UPDATE 
		doctors
    SET 
		doctor_name = @DoctorName,
        doctor_specialization = @DoctorSpecialization,
        doctor_email = @DoctorEmail,
        doctor_phone = @DoctorPhone,
        doctor_room = @DoctorRoom
    WHERE 
		doctor_id = @DoctorID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdatePatient]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdatePatient]
    @PatientID		int,
    @PatientName	nvarchar(100),
    @PatientEmail	nvarchar(50),
    @PatientPhone	nvarchar(20)
AS
BEGIN
    UPDATE 
		patients
    SET	
		patient_name = @PatientName,
        patient_email = @PatientEmail,
        patient_phone = @PatientPhone
    WHERE 
		patient_id = @PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateSpecialization]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateSpecialization]
    @SpecializationID	int,
    @SpecializationName varchar(20)
AS
BEGIN
    UPDATE 
		specializations
    SET 
		specialization_name = @SpecializationName
    WHERE
		specialization_id = @SpecializationID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UserList]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UserList]
AS
BEGIN
    SELECT
		user_id as UserID,
		user_name as UserName,
		uname as UName,
		user_role as UserRole,
		CASE user_role
			WHEN 0 THEN 'Receptionist'
			WHEN 1 THEN 'Admin'
			WHEN 2 THEN 'Super Admin'
		END as UserRoleStr,
		user_status as UserStatus,
		CASE user_status
			WHEN 0 THEN 'Not Active'
			WHEN 1 THEN 'Active'
		END as UserStatusStr
	FROM 
		users
	WHERE
		user_status = 1
	ORDER BY 
		user_role
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UserLogin]    Script Date: 12/6/2024 6:49:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UserLogin]
	@Uname nvarchar(50),
	@Upass nvarchar(MAX)
AS
BEGIN
    SELECT
		user_id as UserID,
		user_name as UserName,
		user_role as UserRole
	FROM
		Users
	WHERE
		uname = @Uname AND 
		upass = @Upass AND 
		user_status = 1
END
GO
USE [master]
GO
ALTER DATABASE [AppointmentSystem] SET  READ_WRITE 
GO
