using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;


public class EditoraDAO
{
    Database banco = Database.Open("ConexaoBanco");
    public int Gravar(Editora obj)
    {
        int sucesso;
        if (obj.EditoraID == 0)
        {
            var sql = "Insert Into Editoras(nome,local)values(@0,@1)";
            sucesso = banco.Execute(sql, obj.Nome, obj.Local);
        }
        else
        {
            var sql = "Update Editoras Set nome=@0, local=@1 Where editoraID=@2";
            sucesso = banco.Execute(sql, obj.Nome, obj.Local, obj.EditoraID);
        }

        banco.Close();
        return sucesso;
    }


    public IList<Editora> ListaEditoras()
    {
        IList<Editora> lista = new List<Editora>();
        var sql = "Select * From Editoras";
        var resultado = banco.Query(sql);
        if (resultado.Count() > 0)
        {
            Editora objEditora;
            foreach (var item in resultado)
            {
                objEditora = new Editora
                {
                    EditoraID = item.editoraID,
                    Nome = item.nome,
                    Local = item.local,
                   
                };
                lista.Add(objEditora);
            }
            banco.Close();
        }
        else
        {
            banco.Close();
            return null;
        }
        return lista;
    }

    public Editora Buscar(int alunoID)
    {
        var sql = "Select * From Editoras Where editoraID = @0";
        var resultado = banco.QuerySingle(sql, alunoID);
        Editora objEditora = new Editora
        {
            EditoraID = resultado.editoraID,
            Nome = resultado.nome,
            Local = resultado.local,
            
        };
        banco.Close();
        return objEditora;
    }
    public void Excluir(int editoraID)
    {
        var sql = "Delete from Editoras where editoraID=@0";
        banco.Execute(sql, editoraID);
        banco.Close();
    }

    //DAO acesso aos dados


}