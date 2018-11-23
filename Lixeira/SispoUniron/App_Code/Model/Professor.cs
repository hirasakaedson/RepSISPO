using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Professor
/// </summary>
public class Professor:Pessoa
{
    public int ProfessorID { get; set; }
    public string Especializacao { get; set; }
    public Curso Objcurso { get; set; }
    
}