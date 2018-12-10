using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Descrição resumida de ProfessorDAO
/// </summary>
public class ProfessorDAO
{
    Database banco = Database.Open("ConexaoBanco");
    public int Gravar(Professor obj)
    {
        int sucesso;
        if (obj.ProfessorID == 0)
        {
            var sql = "Insert Into Professor (nome,matricula,cpf,email, dataNascimento, disicplina)values(@0,@1,@2,@3,@4,@5)";
            sucesso = banco.Execute(sql, obj.Nome, obj.Matricula, obj.Cpf, obj.Email, obj.DataNascimento, obj.ObjDisciplina.Nome);
        }
        else
        {
            var sql = "Update Professor Set nome=@0, matricula=@1, cpf=@2, email=@3 , dataNascimento=@4, disciplina=@5 Where ProfessorID=@6";
            sucesso = banco.Execute(sql, obj.Nome, obj.Matricula, obj.Cpf, obj.Email, obj.DataNascimento, obj.ObjDisciplina.Nome, obj.ProfessorID);
        }

        banco.Close();
        return sucesso;
    }


    public IList<Professor> ListaProfessores()
    {
        IList<Professor> lista = new List<Professor>();
        var sql = "Select * From Professor";
        var resultado = banco.Query(sql);
        if (resultado.Count() > 0)
        {
            Professor objProfessor;
            foreach (var item in resultado)
            {
                objProfessor = new Professor
                {
                    ProfessorID = item.ProfessorID,
                    Nome = item.nome,
                    Matricula = item.matricula,
                    Cpf = item.cpf,
                    Email = item.email, 
                    DataNascimento = item.dataNascimento, 
                    
                };
                lista.Add(objProfessor);
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

    public Professor Buscar(int ProfessorID)
    {
        var sql = "Select * From Professor Where professorID = @0";
        var resultado = banco.QuerySingle(sql, ProfessorID);
        Professor objProfessor = new Professor
        {
            ProfessorID = resultado.professorID,
            Nome = resultado.nome,
            Matricula = resultado.matricula,
            Cpf = resultado.cpf,
            Email = resultado.email,
            DataNascimento = resultado.dataNascimento
          

        };
        banco.Close();
        return objProfessor;
    }
    public void Excluir(int professorID)
    {
        var sql = "Delete from Professor where professorID=@0";
        banco.Execute(sql, professorID);
        banco.Close();
    }
}