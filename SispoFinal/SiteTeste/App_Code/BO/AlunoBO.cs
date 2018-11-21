using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AlunoBO
/// </summary>
public class AlunoBO
{
    public bool Gravar(Aluno obj)
    { 
        if (obj.Nome != string.Empty && obj.Cpf != string.Empty)
        {
            int sucesso = new AlunoDAO().Gravar(obj);
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
    public IList<Aluno> ListaAlunos()
    {
        return new AlunoDAO().ListaAlunos();
    }
    public Aluno Buscar(int alunoID)
    {
        return new AlunoDAO().Buscar(alunoID);
    }
    public void Excluir(int alunoID)
    {
        new AlunoDAO().Excluir(alunoID);  //regras devem ser colocadas aqui na BO

    }

    //BO REGRAS DE NEGOCIOS
}