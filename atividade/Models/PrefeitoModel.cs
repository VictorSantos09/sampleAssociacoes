namespace atividade.Models;
public class PrefeitoModel : PessoaModel
{
    public string Nome { get; set; }
    public string Partido { get; set; }

    public PrefeitoModel(int numero, string sexo) : base(numero, sexo)
    {

    }

    public PrefeitoModel(string nome, string partido, int numero, string sexo) : base(numero, sexo)
    {
        Nome = nome;
        Partido = partido;
    }
}