    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;


public class AlunoDAO
{
    Database banco = Database.Open("ConexaoBanco");
    public int Gravar(Aluno obj)
    {
        int sucesso;
        if (obj.AlunoID == 0)
        {
            var sql = "Insert Into Aluno (nome,matricula,cpf,email, id_Curso)values(@0,@1,@2,@3,@4)";
            sucesso = banco.Execute(sql, obj.Nome, obj.Matricula, obj.Cpf, obj.Email, obj.objCurso.CursoID);
        }
        else
        {
            var sql = "Update aluno Set nome=@0, matricula=@1, cpf=@2, email=@3 , id_Curso = @4 Where alunoID=@5";
            sucesso = banco.Execute(sql, obj.Nome, obj.Matricula, obj.Cpf, obj.Email,obj.objCurso.CursoID , obj.AlunoID);
        }
        
        banco.Close();
        return sucesso;
    }


    public IList<Aluno> ListaAlunos()
    {
        IList<Aluno> lista = new List<Aluno>();
        var sql = "Select * From Aluno";
        var resultado = banco.Query(sql);
        if (resultado.Count() > 0)
        {
            Aluno objAluno;
            foreach (var item in resultado)
            {
                objAluno = new Aluno
                {
                    AlunoID = item.alunoID,
                    Nome = item.nome,
                    Matricula = item.matricula,
                    Cpf = item.cpf,
                    Email = item.email
                };
                lista.Add(objAluno);
            }
            banco.Close();
        }
        else
        {
            banco.Close();
            return null;
        }
        return lista;
    }

    public Aluno Buscar(int alunoID)
    {
        var sql = "Select * From Aluno Where alunoID = @0";
        var resultado = banco.QuerySingle(sql, alunoID);
        Aluno objAluno = new Aluno
        {
            AlunoID = resultado.alunoID,
            Nome = resultado.nome,
            Matricula = resultado.matricula,
            Cpf = resultado.cpf,
            Email = resultado.email
        };
        banco.Close();
        return objAluno;
    }
    public void Excluir(int alunoID)
    {
        var sql = "Delete from Aluno where alunoID=@0";
        banco.Execute(sql, alunoID);
        banco.Close();
    }

   //DAO acesso aos dados

    //testando 
}