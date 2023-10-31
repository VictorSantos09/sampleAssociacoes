namespace atividade.Models;
public class EnderecoModel
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
}
