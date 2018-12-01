using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Descrição resumida de DisciplinaDAO
/// </summary>
public class DisciplinaDAO
{
    Database banco = Database.Open("ConexaoBanco");
    
    public int Gravar(Disciplina obj)
    {
        int sucesso;
        if (obj.DisciplinaID == 0)
        {
            var sql = "Insert Into Disciplina (nome , cargaHoraria)values(@0,@1)";
            sucesso = banco.Execute(sql, obj.Nome, obj.CargaHoraria);
        }
        else
        {
            var sql = "Update Disciplina Set nome=@0, cargaHoraria = @1 Where disciplinaID=@2";
            sucesso = banco.Execute(sql, obj.Nome,  obj.CargaHoraria , obj.DisciplinaID);
        }

        banco.Close();
        return sucesso;
    }



    public Disciplina Buscar(string nome)
    {
        var sql = "select * from Disciplina where nome =  @0";
        var resultado = banco.QuerySingle(sql, nome);

        Disciplina obj = new Disciplina(null);
        obj.CargaHoraria = resultado.cargaHoraria;
        obj.DisciplinaID = resultado.disciplinaID;
        obj.Nome = resultado.nome;

        banco.Close();
        return obj;




        

    }


   
}