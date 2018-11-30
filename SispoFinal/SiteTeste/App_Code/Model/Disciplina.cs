using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Disciplina
/// </summary>
public class Disciplina
{
    //construtor para vincular as disciplinas ao curso que será cadastrado
  public Disciplina(Curso objCurso)
    {

        this.objCurso = objCurso;

    }
       
    public int DisciplinaID { get; set; }
    public string Nome { get; set; }
    public string CargaHoraria { get; set; }
    public Curso objCurso { get; set; }


}