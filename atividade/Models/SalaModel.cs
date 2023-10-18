namespace atividade.Models;
internal class SalaModel
{
    public string Nome { get; set; }
    public int Capacidade { get; set; }

    public SalaModel(string nome, int capacidade)
    {
        Nome = nome;
        Capacidade = capacidade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} - Capacidade: {Capacidade}";
    }
}
