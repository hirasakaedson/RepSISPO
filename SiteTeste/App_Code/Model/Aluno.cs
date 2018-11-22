using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Aluno
/// </summary>
public class Aluno
{
    public int AlunoID { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public IList<Emprestimo> ListaEmprestimo { get; set; }

}