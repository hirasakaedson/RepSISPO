using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida 
/// </summary>
public class AutorBO
{
    public bool Gravar(Autor obj)
    {
        if (obj.Nome != string.Empty)
        {
            int sucesso = new AutorDAO().Gravar(obj);
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
    public IList<Autor> ListaAutores()
    {
        return new AutorDAO().ListaAutores();
    }
    public Autor Buscar(int autorID)
    {
        return new AutorDAO().Buscar(autorID);
    }
    public void Excluir(int autorID)
    {
        new AutorDAO().Excluir(autorID);  //regras devem ser colocadas aqui na BO

    }

    //BO REGRAS DE NEGOCIOS
}