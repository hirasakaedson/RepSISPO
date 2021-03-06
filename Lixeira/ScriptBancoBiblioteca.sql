USE [DbBiblioteca]
select * from autores

GO
/****** Object:  Table [dbo].[Alunos]    Script Date: 03/10/2018 15:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alunos](
	[alunoID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NULL,
	[matricula] [varchar](10) NULL,
	[cpf] [varchar](11) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_Alunos] PRIMARY KEY CLUSTERED 
(
	[alunoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 03/10/2018 15:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[autorID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[sexo] [char](1) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[autorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Editoras]    Script Date: 03/10/2018 15:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editoras](
	[editoraID] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NULL,
	[local] [varchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[editoraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emprestimos]    Script Date: 03/10/2018 15:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emprestimos](
	[emprestimoID] [int] IDENTITY(1,1) NOT NULL,
	[alunoID] [int] NOT NULL,
	[dataEmprestimo] [date] NOT NULL,
	[dataDevolucao] [date] NULL,
 CONSTRAINT [PK_Emprestimos] PRIMARY KEY CLUSTERED 
(
	[emprestimoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Itens]    Script Date: 03/10/2018 15:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itens](
	[itemID] [int] IDENTITY(1,1) NOT NULL,
	[emprestimoID] [int] NULL,
	[livroID] [int] NULL,
 CONSTRAINT [PK_Itens] PRIMARY KEY CLUSTERED 
(
	[itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livros]    Script Date: 03/10/2018 15:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livros](
	[livroID] [int] IDENTITY(1,1) NOT NULL,
	[autorID] [int] NOT NULL,
	[editoraID] [int] NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[dataPublicacao] [date] NULL,
 CONSTRAINT [PK_Livros] PRIMARY KEY CLUSTERED 
(
	[livroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Emprestimos]  WITH CHECK ADD  CONSTRAINT [FK_Emprestimos_Alunos] FOREIGN KEY([alunoID])
REFERENCES [dbo].[Alunos] ([alunoID])
GO
ALTER TABLE [dbo].[Emprestimos] CHECK CONSTRAINT [FK_Emprestimos_Alunos]
GO
ALTER TABLE [dbo].[Itens]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Emprestimos] FOREIGN KEY([emprestimoID])
REFERENCES [dbo].[Emprestimos] ([emprestimoID])
GO
ALTER TABLE [dbo].[Itens] CHECK CONSTRAINT [FK_Itens_Emprestimos]
GO
ALTER TABLE [dbo].[Itens]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Livros] FOREIGN KEY([livroID])
REFERENCES [dbo].[Livros] ([livroID])
GO
ALTER TABLE [dbo].[Itens] CHECK CONSTRAINT [FK_Itens_Livros]
GO
ALTER TABLE [dbo].[Livros]  WITH CHECK ADD  CONSTRAINT [FK_Livros_Autores] FOREIGN KEY([autorID])
REFERENCES [dbo].[Autores] ([autorID])
GO
ALTER TABLE [dbo].[Livros] CHECK CONSTRAINT [FK_Livros_Autores]
GO
ALTER TABLE [dbo].[Livros]  WITH CHECK ADD  CONSTRAINT [FK_Livros_Editoras] FOREIGN KEY([editoraID])
REFERENCES [dbo].[Editoras] ([editoraID])
GO
ALTER TABLE [dbo].[Livros] CHECK CONSTRAINT [FK_Livros_Editoras]
GO
