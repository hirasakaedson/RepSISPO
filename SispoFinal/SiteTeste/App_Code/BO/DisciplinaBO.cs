using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de DisciplinaBO
/// </summary>
public class DisciplinaBO
{
    
    public bool Gravar(Disciplina objDisciplina)
    {
        if (objDisciplina.CargaHoraria != string.Empty && objDisciplina.Nome != string.Empty)
        {
            int sucesso = new DisciplinaDAO().Gravar(objDisciplina);
            if (sucesso !=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        else
        {
            return false;
        }



    }





}