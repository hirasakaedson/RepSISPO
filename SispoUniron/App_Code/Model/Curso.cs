using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Curso
/// </summary>
public class Curso
{
    public int CursoID { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Nome { get; set; }
    public string Turno { get; set; }
    public Professor Objprofessor { get; set; }
    public IList<Aluno> ListaAlunos { get; set; }
    public IList<Disciplina> ListaDisciplinas { get; set; }
    public double ValorMensal { get; set; }

}