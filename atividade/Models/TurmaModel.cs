namespace atividade.Models;
internal class TurmaModel
{
    public string Nome { get; set; }
    public string Periodo { get; set; }

    public TurmaModel(string nome, string periodo)
    {
        Nome = nome;
        Periodo = periodo;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} - Periodo: {Periodo}";
    }
}
