using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Professor
/// </summary>
public class Professor
{
    

    public int ProfessorID { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public Disciplina ObjDisciplina { get; set; }
    public DateTime DataNascimento { get; set; }
    public IList<Emprestimo> ListaEmprestimo { get; set; }




    public int Gravar()
    {
        return new ProfessorDAO().Gravar(this);

    }

}