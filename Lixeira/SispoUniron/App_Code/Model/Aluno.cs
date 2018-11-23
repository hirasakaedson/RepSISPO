using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Aluno
/// </summary>
public class Aluno:Pessoa
{
    public int AlunoID { get; set; }
    public string Ra { get; set; }
    public Curso Objcurso { get; set; }
}