namespace atividade.Models;
public class PrefeitoModel : PessoaModel
{
    public string Partido { get; set; }

    public PrefeitoModel(string nome, string sexo) : base(nome, sexo)
    {

    }

    public PrefeitoModel(string nome, string partido, string sexo) : base(nome, sexo)
    {
        Nome = nome;
        Partido = partido;
    }
}