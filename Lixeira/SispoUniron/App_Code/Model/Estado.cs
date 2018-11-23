using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Estado
/// </summary>
public class Estado
{
    public int EstadoId { get; set; }
    public string Rua { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }
    public string Uf { get; set; }
    public Aluno Objaluno { get; set; }
    public Professor Objprofessor { get; set; }
    public Funcionario Objfuncionario { get; set; }

}