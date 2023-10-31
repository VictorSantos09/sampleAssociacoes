using atividade.Models;

namespace atividade.Services;
public static class EnderecoService
{
    public static EnderecoModel Criar()
    {
        string rua = ConsoleExtension.WriteAndRead("Rua");
        int numero = int.Parse(ConsoleExtension.WriteAndRead("Número"));
        string cep = ConsoleExtension.WriteAndRead("CEP");
        CidadeModel cidade = CidadeService.Criar();

        EnderecoModel endereco = new EnderecoModel(rua, numero, cep, cidade);
        return endereco;
    }
}
