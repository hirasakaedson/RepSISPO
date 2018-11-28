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
    public string Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public Double ValorMensal { get; set; }
    public IList<Disciplina> ListaDisciplinas { get; set; }
    
    public Curso()
    {
        ListaDisciplinas = new List<Disciplina>();
    }


}