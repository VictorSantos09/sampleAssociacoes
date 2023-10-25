namespace atividade.Models;
internal class PrefeitoModel
{
    public string Nome { get; set; }
    public string Partido { get; set; }

    public PrefeitoModel()
    {
        
    }
    public PrefeitoModel(string nome, string partido)
    {
        Nome = nome;
        Partido = partido;
    }
}