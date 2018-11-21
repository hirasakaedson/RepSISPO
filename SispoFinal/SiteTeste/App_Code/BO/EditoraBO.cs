using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///
/// </summary>
public class EditoraBO
{
    public bool Gravar(Editora obj)
    {
        if (obj.Nome != string.Empty)
        {
            int sucesso = new EditoraDAO().Gravar(obj);
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
    public IList<Editora> ListaEditoras()
    {
        return new EditoraDAO().ListaEditoras();
    }
    public Editora Buscar(int editoraID)
    {
        return new EditoraDAO().Buscar(editoraID);
    }
    public void Excluir(int editoraID)
    {
        new EditoraDAO().Excluir(editoraID);  //regras devem ser colocadas aqui na BO

    }

    //BO REGRAS DE NEGOCIOS
}