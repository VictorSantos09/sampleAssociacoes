using atividade.Interfaces;

namespace atividade.Models;
public class EnderecoModel : ILocalizacao
{
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string CEP { get; set; }
    public CidadeModel Cidade { get; set; }

    public EnderecoModel(string rua, int numero, string cEP, CidadeModel cidade)
    {
        Rua = rua;
        Numero = numero;
        CEP = cEP;
        Cidade = cidade;
    }

    public EnderecoModel()
    {

    }

    public string MapaBase64(float latitude, float longitude)
    {
        return $"{latitude} {longitude}";
    }
}
