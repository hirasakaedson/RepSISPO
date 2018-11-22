using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Emprestimo
/// </summary>
public class Emprestimo
{
    public int EmprestimoID { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
    public Aluno ObjAluno { get; set; }
    public IList<Item> ListaItem { get; set; }
}