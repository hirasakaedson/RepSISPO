using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

/// <summary>
/// Descrição resumida de Conexao
/// </summary>
public class Conexao
{

    // uso de singleton para poder invocar a propriedade banco de qualquer outra classe.
    //obs esta classe se instacia só e vc não pode instancia-la de outro escopo.
    public static Conexao _instancia = null;

    private Conexao()
    {

    }

    public static Conexao Instancia
    {
        get
        {
            _instancia = new Conexao();

            return _instancia = new Conexao();

        }
    }


    public Database banco = new Database.Open("conexaoBanco");

}