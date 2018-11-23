using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Autor
/// </summary>
public class Autor
{
    public int AutorID { get; set; }
    public string Nome { get; set; }
    public char Sexo { get; set; }
    public IList<Livro> ListaLivro { get; set; }

}