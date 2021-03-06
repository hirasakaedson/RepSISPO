USE [master]
GO
/****** Object:  Database [db_sispo]    Script Date: 22/11/2018 17:27:22 ******/
CREATE DATABASE [db_sispo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_sispo', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_sispo.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_sispo_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_sispo_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_sispo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_sispo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_sispo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_sispo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_sispo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_sispo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_sispo] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_sispo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_sispo] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_sispo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_sispo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_sispo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_sispo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_sispo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_sispo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_sispo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_sispo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_sispo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_sispo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_sispo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_sispo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_sispo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_sispo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_sispo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_sispo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_sispo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_sispo] SET  MULTI_USER 
GO
ALTER DATABASE [db_sispo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_sispo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_sispo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_sispo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [db_sispo]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 22/11/2018 17:27:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aluno](
	[alunoID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[cpf] [varchar](11) NOT NULL,
	[dataNascimento] [datetime] NULL,
	[idade] [numeric](2, 0) NULL,
	[endereco] [varchar](40) NULL,
	[matricula] [varchar](20) NOT NULL,
	[email] [varchar](40) NOT NULL,
	[nomeResponsavel] [varchar](30) NULL,
 CONSTRAINT [PK__Aluno__B969DA5D4DC67EBD] PRIMARY KEY CLUSTERED 
(
	[alunoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_AlunoCpf] UNIQUE NONCLUSTERED 
(
	[cpf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 22/11/2018 17:27:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curso](
	[cursoID] [int] IDENTITY(1,1) NOT NULL,
	[dtInicio] [datetime] NULL,
	[dtFinal] [datetime] NULL,
	[descricao] [varchar](30) NULL,
	[id_Disciplica] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cursoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diario]    Script Date: 22/11/2018 17:27:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diario](
	[diarioID] [int] IDENTITY(1,1) NOT NULL,
	[dataPresenca] [datetime] NOT NULL,
	[qtdAlunos] [smallint] NULL,
	[id_Aluno] [int] NULL,
	[id_Professor] [int] NULL,
	[id_Curso] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[diarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 22/11/2018 17:27:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disciplina](
	[disciplinaID] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](20) NOT NULL,
	[qtdHoras] [numeric](6, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[disciplinaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 22/11/2018 17:27:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Professor](
	[professorID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[idade] [numeric](2, 0) NOT NULL,
	[endereco] [varchar](40) NOT NULL,
	[matricula] [numeric](5, 0) NOT NULL,
	[email] [varchar](40) NOT NULL,
	[formacao] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[professorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD FOREIGN KEY([id_Disciplica])
REFERENCES [dbo].[Disciplina] ([disciplinaID])
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD  CONSTRAINT [FK__Diario__id_Aluno__1920BF5C] FOREIGN KEY([id_Aluno])
REFERENCES [dbo].[Aluno] ([alunoID])
GO
ALTER TABLE [dbo].[Diario] CHECK CONSTRAINT [FK__Diario__id_Aluno__1920BF5C]
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD FOREIGN KEY([id_Curso])
REFERENCES [dbo].[Curso] ([cursoID])
GO
ALTER TABLE [dbo].[Diario]  WITH CHECK ADD FOREIGN KEY([id_Professor])
REFERENCES [dbo].[Professor] ([professorID])
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Evitar ter Cpfs duplicados no banco' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Aluno', @level2type=N'CONSTRAINT',@level2name=N'IX_AlunoCpf'
GO
USE [master]
GO
ALTER DATABASE [db_sispo] SET  READ_WRITE 
GO
