using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Item
/// </summary>
public class Item
{
    public int ItemID { get; set; }
    public Emprestimo ObjEmprestimo { get; set; }
    public Livro ObjLivro { get; set; }

}