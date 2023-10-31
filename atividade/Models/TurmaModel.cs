namespace atividade.Models;
public class TurmaModel
{
    public string Nome { get; set; }
    public string Periodo { get; set; }

    public TurmaModel(string nome, string periodo)
    {
        Nome = nome;
        Periodo = periodo;
    }
}
