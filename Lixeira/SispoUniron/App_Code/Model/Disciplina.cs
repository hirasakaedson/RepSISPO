using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Disciplina
/// </summary>
public class Disciplina
{
    public int DisciplinaID { get; set; }
    public string Nome { get; set; }
    public IList<Curso> ListaCursos { get; set; }



}