using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;


public class AutorDAO
{
    Database banco = Database.Open("ConexaoBanco");
    public int Gravar(Autor obj)
    {
        int sucesso;
        if (obj.AutorID == 0)
        {
            var sql = "Insert Into Autores(nome,sexo)values(@0,@1)";
            sucesso = banco.Execute(sql, obj.Nome, obj.Sexo);
        }
        else
        {
            var sql = "Update Autores Set nome=@0, sexo=@1 Where autorID=@2";
            sucesso = banco.Execute(sql, obj.Nome, obj.Sexo, obj.AutorID);
        }

        banco.Close();
        return sucesso;
    }


    public IList<Autor> ListaAutores()
    {
        IList<Autor> lista = new List<Autor>();
        var sql = "Select * From Autores";
        var resultado = banco.Query(sql);
        if (resultado.Count() > 0)
        {
            Autor objAutor;
            foreach (var item in resultado)
            {
                objAutor = new Autor
                {
                    AutorID = item.autorID,
                    Nome = item.nome,
                    Sexo = Convert.ToChar(item.sexo),
                    
                };
                lista.Add(objAutor);
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

    public Autor Buscar(int autorID)
    {
        var sql = "Select * From Autores Where autorID = @0";
        var resultado = banco.QuerySingle(sql, autorID);
       Autor objAutor = new Autor
        {
            AutorID = resultado.autorID,
            Nome = resultado.nome,
            Sexo = resultado.sexo,
           
        };
        banco.Close();
        return objAutor;
    }
    public void Excluir(int autorID)
    {
        var sql = "Delete from Autores where autorID=@0";
        banco.Execute(sql, autorID);
        banco.Close();
    }

    //DAO acesso aos dados


}