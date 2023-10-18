namespace atividade.Models;
internal class EnderecoModel
{
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Cidade { get; set; }
    public string CEP { get; set; }

    public EnderecoModel(string rua, int numero, string cidade, string cEP)
    {
        Rua = rua;
        Numero = numero;
        Cidade = cidade;
        CEP = cEP;
    }

    public EnderecoModel()
    {

    }
}
