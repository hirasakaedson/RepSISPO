using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pessoa
/// </summary>
public class Pessoa
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
    public int Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Cidade { get; set; }
    public DateTime DataNascimento { get; set; }
    public IList<string> ListaUfs { get; set; }





}