using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoBO
/// </summary>
public class CursoBO
{
   

    public bool  Gravar(Curso objCurso)
    {
        if (objCurso.Descricao != string.Empty )
        {
            int sucesso = new CursoDAO().Gravar(objCurso);
            if (sucesso != 0 )
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


    public IList<Curso> ListaCurso()
    {

        return new CursoDAO().ListaCurso();

                          
    }




}