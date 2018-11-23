using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Livro
/// </summary>
public class Livro
{
    public int LivroID { get; set; }
    public string Nome { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Autor ObjAutor { get; set; }
    public Editora ObjEditora { get; set; }

}