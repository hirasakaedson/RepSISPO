create database db_sispo
use db_sispo


select * from aluno
create table Aluno(
alunoID integer identity(1,1)primary key not null,
cursoID integer not null,
disciplinaID integer not null,
nome varchar(30) not null,
cpf varchar(14) not null,
dataNascimento datetime not null,
idade numeric(2) not null,
endereco varchar(40) not null,
matricula numeric(5) not null,
email varchar(40) not null,
nomeResponsavel varchar(30)not null
)
create table Professor(
professorID integer identity(1,1)primary key not null,
cursoID integer not null,
disciplinaID integer not null,
nome varchar(30) not null,
cpf varchar(14) not null,
dataNascimento datetime not null,
idade numeric(2) not null,
endereco varchar(40) not null,
matricula numeric(5) not null,
email varchar(40) not null,
formacao varchar(20)not null
)
Create table Disciplina(
disciplinaID integer identity(1,1)primary key not null,
descricao varchar(20) not null,
qtdHoras numeric (6,2)
)
create table Curso(
cursoID integer identity(1,1) primary key not null,
dtInicio datetime,
dtFinal datetime,
descricao varchar(30),
id_Disciplica integer references Disciplina
)
create table Diario(
diarioID integer identity(1,1) primary key not null,
dataPresenca datetime not null,
qtdAlunos smallint,
id_Aluno integer references Aluno,
id_Professor integer references Professor,
id_Curso integer references Curso

)
