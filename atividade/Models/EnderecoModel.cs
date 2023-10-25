namespace atividade.Models;
internal class EnderecoModel
{
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string CEP { get; set; }

    public EnderecoModel(string rua, int numero, string cEP)
    {
        Rua = rua;
        Numero = numero;
        CEP = cEP;
    }

    public EnderecoModel()
    {

    }
}
