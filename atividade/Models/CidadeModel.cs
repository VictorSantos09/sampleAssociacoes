namespace atividade.Models;
internal class CidadeModel
{
    public string Nome { get; set; }
    public string SiglaUF { get; set; }
    public List<EnderecoModel> Enderecos { get; set; }
    public PrefeitoModel Prefeito { get; set; }

    public CidadeModel(string nome, string siglaUF, string nomePrefeito, string partidoFreteito)
    {
        Nome = nome;
        SiglaUF = siglaUF;
        Enderecos = new();
        Prefeito = new(nomePrefeito, partidoFreteito);
    }

}
