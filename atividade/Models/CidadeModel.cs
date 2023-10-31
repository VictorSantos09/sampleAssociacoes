using atividade.Interfaces;

namespace atividade.Models;
public class CidadeModel : ILocalizacao
{
    public string Nome { get; set; }
    public string SiglaUF { get; set; }
    public PrefeitoModel Prefeito { get; set; }
    
    public CidadeModel()
    {
        
    }

    public CidadeModel(string nomePrefeito, string partidoPrefeito, int numeroPrefeito, string sexoPrefeito, string nomeCidade, string siglaUF)
    {
        Nome = nomeCidade;
        SiglaUF = siglaUF;
        Prefeito = new(nomePrefeito, partidoPrefeito, numeroPrefeito, sexoPrefeito);
    }

    public string MapaBase64(float latitude, float longitude)
    {
        return $"{latitude} {longitude}";
    }
}
