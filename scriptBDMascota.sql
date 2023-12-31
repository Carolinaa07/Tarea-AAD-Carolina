USE [master]
GO
/****** Object:  Database [db_mascotas]    Script Date: 31/10/2023 13:01:29 ******/
CREATE DATABASE [db_mascotas]
 CONTAINMENT = NONE
 ON  PRIMARY 

ALTER DATABASE [db_mascotas] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_mascotas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_mascotas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_mascotas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_mascotas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_mascotas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_mascotas] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_mascotas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_mascotas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_mascotas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_mascotas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_mascotas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_mascotas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_mascotas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_mascotas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_mascotas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_mascotas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_mascotas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_mascotas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_mascotas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_mascotas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_mascotas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_mascotas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_mascotas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_mascotas] SET RECOVERY FULL 
GO
ALTER DATABASE [db_mascotas] SET  MULTI_USER 
GO
ALTER DATABASE [db_mascotas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_mascotas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_mascotas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_mascotas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_mascotas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_mascotas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_mascotas', N'ON'
GO
ALTER DATABASE [db_mascotas] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_mascotas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_mascotas]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 31/10/2023 13:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreDueno] [varchar](100) NOT NULL,
	[Tamanio] [decimal](6, 2) NOT NULL,
	[Peso] [decimal](6, 2) NOT NULL,
	[FechaNacimeinto] [date] NOT NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_mascotas]    Script Date: 31/10/2023 13:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listar_mascotas]
as
select * from [Mascota]
GO
/****** Object:  StoredProcedure [dbo].[sp_mantenimiento_mascotas]    Script Date: 31/10/2023 13:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mantenimiento_mascotas]
@id_ int,
@due_ varchar(100),
@tam_ decimal,
@pes_ decimal,
@fecha_ date,
@opcion int
as
if(@opcion=1)
begin
    SET IDENTITY_INSERT [Mascota] ON  
    insert into [Mascota] (Id,NombreDueno, Tamanio, Peso, FechaNacimeinto) values (@id_, @due_, @tam_, @pes_, @fecha_)
    SET IDENTITY_INSERT [Mascota] OFF 
end
else if(@opcion=2)
begin
    update [Mascota] set NombreDueno = @due_, Tamanio = @tam_, Peso = @pes_, FechaNacimeinto = @fecha_ where Id = @id_
end
else
begin
    delete from [Mascota] where Id = @id_
end
GO
USE [master]
GO
ALTER DATABASE [db_mascotas] SET  READ_WRITE 
GO
