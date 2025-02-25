USE [master]
GO
/****** Object:  Database [BD_REINA_FACULTAD]    Script Date: 30/7/2024 19:51:49 ******/
CREATE DATABASE [BD_REINA_FACULTAD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_REINA_FACULTAD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BD_REINA_FACULTAD.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_REINA_FACULTAD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BD_REINA_FACULTAD_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_REINA_FACULTAD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET  MULTI_USER 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET QUERY_STORE = ON
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BD_REINA_FACULTAD]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](100) NOT NULL,
	[Estado] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CandidataId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Candidata]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidata](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](20) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Edad] [nvarchar](100) NOT NULL,
	[Correo] [nvarchar](100) NOT NULL,
	[Celular] [nvarchar](20) NOT NULL,
	[Carrera] [nvarchar](100) NOT NULL,
	[Nivel] [nvarchar](100) NOT NULL,
	[Pasatiempos] [nvarchar](max) NULL,
	[Habilidades] [nvarchar](max) NULL,
	[Intereses] [nvarchar](max) NULL,
	[Aspiraciones] [nvarchar](max) NULL,
	[Foto] [image] NULL,
	[Estado] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FotoId] [int] NOT NULL,
	[EstudianteId] [int] NOT NULL,
	[TextoComentario] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Matricula] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Estado] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foto]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlbumId] [int] NOT NULL,
	[Titulo] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
	[Foto] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](100) NOT NULL,
	[Contraseña] [nvarchar](100) NOT NULL,
	[RolId] [int] NOT NULL,
	[Estado] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Votacion]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Votacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CandidataId] [int] NOT NULL,
	[EstudianteId] [int] NOT NULL,
	[TipoVoto] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrador]  WITH CHECK ADD FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Album]  WITH CHECK ADD FOREIGN KEY([CandidataId])
REFERENCES [dbo].[Candidata] ([Id])
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiante] ([Id])
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([FotoId])
REFERENCES [dbo].[Foto] ([Id])
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Foto]  WITH CHECK ADD FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Album] ([Id])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Votacion]  WITH CHECK ADD FOREIGN KEY([CandidataId])
REFERENCES [dbo].[Candidata] ([Id])
GO
ALTER TABLE [dbo].[Votacion]  WITH CHECK ADD FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiante] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarAdministrador]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarAdministrador]
    @Id INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Cedula NVARCHAR(50),
    @Contraseña NVARCHAR(50),
    @Estado NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar en la tabla Usuario
    UPDATE Usuario
    SET Cedula = @Cedula, Contraseña = @Contraseña, Estado = @Estado
    WHERE Id = (SELECT UsuarioId FROM Administrador WHERE Id = @Id);

    -- Actualizar en la tabla Administrador
    UPDATE Administrador
    SET Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, Contraseña = @Contraseña, Estado = @Estado
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarCandidata]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarCandidata]
    @Id INT,
    @Cedula NVARCHAR(50),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Edad NVARCHAR(10),
    @Correo NVARCHAR(100),
    @Celular NVARCHAR(20),
    @Carrera NVARCHAR(100),
    @Nivel NVARCHAR(50),
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX),
    @Foto VARBINARY(MAX),
    @Estado NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Candidata
    SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Correo = @Correo, Celular = @Celular,
        Carrera = @Carrera, Nivel = @Nivel, Pasatiempos = @Pasatiempos, Habilidades = @Habilidades, 
        Intereses = @Intereses, Aspiraciones = @Aspiraciones, Foto = @Foto, Estado = @Estado
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstudiante]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarEstudiante]
    @Id INT,
    @Matricula NVARCHAR(100),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Cedula NVARCHAR(50),
    @Contraseña NVARCHAR(50),
    @Estado NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar en la tabla Usuario
    UPDATE Usuario
    SET Cedula = @Cedula, Contraseña = @Contraseña, Estado = @Estado
    WHERE Id = (SELECT UsuarioId FROM Estudiante WHERE Id = @Id);

    -- Actualizar en la tabla Estudiante
    UPDATE Estudiante
    SET Matricula = @Matricula, Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, Contraseña = @Contraseña, Estado = @Estado
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarFotos]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarFotos]
    @IdFoto1 INT,
    @Titulo1 NVARCHAR(100),
    @Descripcion1 NVARCHAR(255),
    @Foto1 VARBINARY(MAX),
    
    @IdFoto2 INT,
    @Titulo2 NVARCHAR(100),
    @Descripcion2 NVARCHAR(255),
    @Foto2 VARBINARY(MAX),
    
    @IdFoto3 INT,
    @Titulo3 NVARCHAR(100),
    @Descripcion3 NVARCHAR(255),
    @Foto3 VARBINARY(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar la primera foto
    UPDATE Foto
    SET Titulo = @Titulo1,
        Descripcion = @Descripcion1,
        Foto = @Foto1
    WHERE Id = @IdFoto1;

    -- Actualizar la segunda foto
    UPDATE Foto
    SET Titulo = @Titulo2,
        Descripcion = @Descripcion2,
        Foto = @Foto2
    WHERE Id = @IdFoto2;

    -- Actualizar la tercera foto
    UPDATE Foto
    SET Titulo = @Titulo3,
        Descripcion = @Descripcion3,
        Foto = @Foto3
    WHERE Id = @IdFoto3;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarAdministradores]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarAdministradores]
    @Cedula NVARCHAR(50) = NULL,
    @Estado NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * 
    FROM Administrador
    WHERE (@Cedula IS NULL OR Cedula = @Cedula)
    AND (@Estado IS NULL OR Estado = @Estado);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarAlbum]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarAlbum]
    @Id INT,
    @Existe BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el álbum existe
    IF EXISTS (SELECT 1 FROM Album WHERE CandidataId = @Id)
    BEGIN
        SET @Existe = 1; -- El álbum existe
    END
    ELSE
    BEGIN
        SET @Existe = 0; -- El álbum no existe
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarCandidatas]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarCandidatas]
    @Cedula NVARCHAR(50) = NULL,
    @Estado NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * 
    FROM Candidata
    WHERE (@Cedula IS NULL OR Cedula = @Cedula)
    AND (@Estado IS NULL OR Estado = @Estado);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarCandidatasPorId]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarCandidatasPorId]
    @Id INT
AS
BEGIN
    SELECT * FROM Candidata
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarCandidatasPorNombre]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarCandidatasPorNombre]
    @Nombre NVARCHAR(100) = NULL
AS
BEGIN
    SELECT * 
    FROM Candidata
    WHERE (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
      AND Estado = 'Activo'; -- Filtra solo las candidatas con estado activo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarEstudiantes]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarEstudiantes]
    @Cedula NVARCHAR(50) = NULL,
    @Estado NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * 
    FROM Estudiante
    WHERE (@Cedula IS NULL OR Cedula = @Cedula)
    AND (@Estado IS NULL OR Estado = @Estado);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarFotosPorCandidata]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultarFotosPorCandidata]
    @IdCandidata INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Declarar variable para almacenar el ID del álbum
    DECLARE @IdAlbum INT;

    -- Encontrar el álbum asociado al ID de la candidata
    SELECT @IdAlbum = Id
    FROM Album
    WHERE CandidataId = @IdCandidata;

    -- Verificar si se encontró un álbum
    IF @IdAlbum IS NOT NULL
    BEGIN
        -- Devolver todas las fotos asociadas al álbum encontrado
        SELECT Id, AlbumId, Titulo, Descripcion, Foto
        FROM Foto
        WHERE AlbumId = @IdAlbum;
    END
    ELSE
    BEGIN
        -- Si no se encontró el álbum, devolver un conjunto vacío o mensaje de error
        SELECT 'No se encontró un álbum para la candidata especificada.' AS Mensaje;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ContarVotosPorCandidata]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ContarVotosPorCandidata]
    @CandidataId INT
AS
BEGIN
    -- Seleccionar la cantidad de votos de Fotogenia y Reina para la candidata específica
    SELECT 
        COUNT(CASE WHEN TipoVoto = 'Fotogenia' THEN 1 END) AS VotosFotogenia,
        COUNT(CASE WHEN TipoVoto = 'Reina' THEN 1 END) AS VotosReina
    FROM 
        Votacion
    WHERE 
        CandidataId = @CandidataId;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarAdministrador]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarAdministrador]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el estado a 'Inactivo' en la tabla Administrador
    UPDATE Administrador
    SET Estado = 'Inactivo'
    WHERE UsuarioId = @Id;

    -- También actualizamos el estado en la tabla Usuario
    UPDATE Usuario
    SET Estado = 'Inactivo'
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCandidata]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarCandidata]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el estado a 'Inactivo'
    UPDATE Candidata
    SET Estado = 'Inactivo'
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarEstudiante]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarEstudiante]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el estado a 'Inactivo'
    UPDATE Estudiante
    SET Estado = 'Inactivo'
    WHERE UsuarioId = @Id;

    -- También actualizamos el estado en la tabla Usuario
    UPDATE Usuario
    SET Estado = 'Inactivo'
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarAdministrador]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarAdministrador]
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Cedula NVARCHAR(50),
    @Contraseña NVARCHAR(50),
    @Estado NVARCHAR(10) = 'Activo'  -- Valor por defecto 'Activo' para activo
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UsuarioId INT;

    -- Insertar en la tabla Usuario
    INSERT INTO Usuario (Cedula, Contraseña, RolId, Estado)
    VALUES (@Cedula, @Contraseña, 1, @Estado);  -- 1 es el RolId para Administrador

    -- Obtener el Id del usuario recién insertado
    SET @UsuarioId = SCOPE_IDENTITY();

    -- Insertar en la tabla Administrador
    INSERT INTO Administrador (UsuarioId, Nombre, Apellido, Cedula, Contraseña, Estado)
    VALUES (@UsuarioId, @Nombre, @Apellido, @Cedula, @Contraseña, @Estado);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarCandidata]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarCandidata]
    @Cedula NVARCHAR(50),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Edad NVARCHAR(10),
    @Correo NVARCHAR(100),
    @Celular NVARCHAR(20),
    @Carrera NVARCHAR(100),
    @Nivel NVARCHAR(50),
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX),
    @Foto VARBINARY(MAX),
    @Estado NVARCHAR(10) = 'Activo'  -- Valor por defecto 'Activo'
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Candidata (Cedula, Nombre, Apellido, Edad, Correo, Celular, Carrera, Nivel, Pasatiempos, Habilidades, Intereses, Aspiraciones, Foto, Estado)
    VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Correo, @Celular, @Carrera, @Nivel, @Pasatiempos, @Habilidades, @Intereses, @Aspiraciones, @Foto, @Estado);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarComentario]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarComentario]
    @FotoId INT,
    @UsuarioId INT,  -- Cambiado de EstudianteId a UsuarioId
    @TextoComentario NVARCHAR(255)
AS
BEGIN
    -- Declarar una variable para almacenar el EstudianteId
    DECLARE @EstudianteId INT;

    -- Buscar el EstudianteId basado en el UsuarioId
    SELECT @EstudianteId = Id
    FROM Estudiante
    WHERE UsuarioId = @UsuarioId;

    -- Verificar que el comentario no esté vacío o solo contenga espacios en blanco
    IF LTRIM(RTRIM(@TextoComentario)) <> ''
    BEGIN
        -- Insertar los datos en la tabla de votaciones
        INSERT INTO Comentario(FotoId, EstudianteId, TextoComentario)
        VALUES (@FotoId, @EstudianteId, @TextoComentario);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarEstudiante]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarEstudiante]
    @Matricula NVARCHAR(100),
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Cedula NVARCHAR(50),
    @Contraseña NVARCHAR(50),
    @Estado NVARCHAR(10) = 'Activo'  -- Valor por defecto 'Activo' para activo
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UsuarioId INT;

    -- Insertar en la tabla Usuario
    INSERT INTO Usuario (Cedula, Contraseña, RolId, Estado)
    VALUES (@Cedula, @Contraseña, 2, @Estado);  -- 2 es el RolId para Estudiante

    -- Obtener el Id del usuario recién insertado
    SET @UsuarioId = SCOPE_IDENTITY();

    -- Insertar en la tabla Estudiante
    INSERT INTO Estudiante (UsuarioId, Matricula, Nombre, Apellido, Cedula, Contraseña, Estado)
    VALUES (@UsuarioId, @Matricula, @Nombre, @Apellido, @Cedula, @Contraseña, @Estado);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarVotacion]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarVotacion]
    @CandidataId INT,
    @UsuarioId INT,  -- Cambiado de EstudianteId a UsuarioId
    @TipoVoto NVARCHAR(50)
AS
BEGIN
    -- Declarar una variable para almacenar el EstudianteId
    DECLARE @EstudianteId INT;

    -- Buscar el EstudianteId basado en el UsuarioId
    SELECT @EstudianteId = Id
    FROM Estudiante
    WHERE UsuarioId = @UsuarioId;

    -- Insertar los datos en la tabla de votaciones
    INSERT INTO Votacion (CandidataId, EstudianteId, TipoVoto)
    VALUES (@CandidataId, @EstudianteId, @TipoVoto);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarAlbum]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarAlbum]
    @IdCandidata INT,
    @Imagen1 VARBINARY(MAX),
    @Titulo1 NVARCHAR(255),
    @Descripcion1 NVARCHAR(MAX),
    @Imagen2 VARBINARY(MAX),
    @Titulo2 NVARCHAR(255),
    @Descripcion2 NVARCHAR(MAX),
    @Imagen3 VARBINARY(MAX),
    @Titulo3 NVARCHAR(255),
    @Descripcion3 NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IdAlbum INT;

    -- 1. Crear el álbum
    INSERT INTO Album (CandidataId)
    VALUES (@IdCandidata);

    -- Obtener el ID del álbum recién creado
    SET @IdAlbum = SCOPE_IDENTITY();

    -- 2. Insertar las fotos
    INSERT INTO Foto (AlbumId, Titulo, Descripcion, Foto)
    VALUES (@IdAlbum, @Titulo1, @Descripcion1, @Imagen1);

    INSERT INTO Foto (AlbumId, Titulo, Descripcion, Foto)
    VALUES (@IdAlbum, @Titulo2, @Descripcion2, @Imagen2);

    INSERT INTO Foto (AlbumId, Titulo, Descripcion, Foto)
    VALUES (@IdAlbum, @Titulo3, @Descripcion3, @Imagen3);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ValidarUsuario]
    @Cedula NVARCHAR(100),
    @Contraseña NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM Usuario
    WHERE Cedula = @Cedula AND Contraseña = @Contraseña AND Estado = 'Activo';
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VerificarVotacion]    Script Date: 30/7/2024 19:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_VerificarVotacion]
    @UsuarioId INT,
    @TipoVoto NVARCHAR(50)
AS
BEGIN
    -- Declarar una variable para almacenar el EstudianteId
    DECLARE @EstudianteId INT;

    -- Buscar el EstudianteId basado en el UsuarioId
    SELECT @EstudianteId = Id
    FROM Estudiante
    WHERE UsuarioId = @UsuarioId;

    -- Verificar si hay una votación para el EstudianteId y el TipoVoto
    IF @EstudianteId IS NOT NULL
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM Votacion
            WHERE EstudianteId = @EstudianteId
              AND TipoVoto = @TipoVoto
        )
        BEGIN
            -- Retornar un valor para indicar que la votación ya existe
            SELECT 1 AS ExisteVotacion;
        END
        ELSE
        BEGIN
            -- Retornar un valor para indicar que la votación no existe
            SELECT 0 AS ExisteVotacion;
        END
    END
    ELSE
    BEGIN
        -- Retornar un valor para indicar que el EstudianteId no fue encontrado
        SELECT 0 AS ExisteVotacion;
    END
END
GO
USE [master]
GO
ALTER DATABASE [BD_REINA_FACULTAD] SET  READ_WRITE 
GO
