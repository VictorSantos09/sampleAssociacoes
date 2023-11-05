namespace atividade.Models;
public class PessoaModel
{
    public string Nome { get; set; }
    public string Sexo { get; set; }

    public PessoaModel(string sexo, string nome)
    {
        Sexo = sexo;
        Nome = nome;
    }
}
