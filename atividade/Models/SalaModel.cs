namespace atividade.Models;
public class SalaModel
{
    public string Nome { get; set; }
    public int Capacidade { get; set; }

    public SalaModel(string nome, int capacidade)
    {
        Nome = nome;
        Capacidade = capacidade;
    }
}
