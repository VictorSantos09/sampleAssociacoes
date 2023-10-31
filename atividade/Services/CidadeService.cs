using atividade.Models;

namespace atividade.Services;
public static class CidadeService
{
    public static CidadeModel Criar()
    {
        string nomePrefeito = ConsoleExtension.WriteAndRead("Nome do prefeito");
        string partidoPrefeito = ConsoleExtension.WriteAndRead("Partido do prefeito");
        int numeroPrefeito = int.Parse(ConsoleExtension.WriteAndRead("Nº do prefeito"));
        string sexoPrefeito = ConsoleExtension.WriteAndRead("Sexo do prefeito");
        string nomeCidade = ConsoleExtension.WriteAndRead("Nome da cidade");
        string siglaUf = ConsoleExtension.WriteAndRead("Sigla UF");
        CidadeModel cidade = new(nomePrefeito, partidoPrefeito, numeroPrefeito, sexoPrefeito, nomeCidade, siglaUf);
        FakeDatabase.Cidades.Add(cidade);
        return cidade;
    }
}
