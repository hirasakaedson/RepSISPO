using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ProfessorBO
/// </summary>
public class ProfessorBO
{
    public bool Gravar(Professor obj)
    {
        if (obj.Nome != string.Empty && obj.Cpf != string.Empty)
        {
            int sucesso = new ProfessorDAO().Gravar(obj);
            if (sucesso != 0)
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
    public IList<Professor> ListaProfessores()
    {
        return new ProfessorDAO().ListaProfessores();
    }
    public Professor Buscar(int ProfessorID)
    {
        return new ProfessorDAO().Buscar(ProfessorID);
    }
    public void Excluir(int alunoID)
    {
        new AlunoDAO().Excluir(alunoID);  //regras devem ser colocadas aqui na BO

    }
}