using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Descrição resumida de CursoDAO
/// </summary>
public class CursoDAO
{
    Database banco = Database.Open("ConexaoBanco");


    public int Gravar(Curso objCurso)
    {
        var sql = "insert into Curso(dtInicio, dtFinal , descricao , valorMensal) values(@0, @1 , @2, @3)";
        int sucesso = banco.Execute(sql, objCurso.DataInicio, objCurso.DataFim, objCurso.Descricao, objCurso.ValorMensal);
        return sucesso;
    }


    public IList<Curso> ListaCurso()
    {

        IList<Curso> lista = new List<Curso>();
        var sql = "select * from Curso";
        var resultado = banco.Query(sql);

        if (resultado.Count() > 0)
        {

            Curso objCurso;
            foreach (var item in resultado)
            {

                objCurso = new Curso
                {
                    CursoID = item.cursoID,
                    Descricao = item.descricao,
                    DataInicio = item.dtInicio,
                    DataFim = item.dtFinal,
                    ValorMensal = Convert.ToDouble(item.valorMensal)
                                     


                };
                lista.Add(objCurso);


            }
            banco.Close();

        }
        else
        {
            return null;
        }

        return lista;





    }


}