using atividade.Models;

namespace atividade.Services;
internal class ProfessorService
{
    public static ProfessorModel Cadastrar()
    {
        string nome = ConsoleExtension.WriteAndRead("Nome");
        string sexo = ConsoleExtension.WriteAndRead("Sexo");
        int numeroMatricula = int.Parse(ConsoleExtension.WriteAndRead("Numero da matricula"));

        string option = ConsoleExtension.WriteAndRead("Deseja cadastrar o endereço?\n 1 - SIM\n 2 - NÃO");

        ProfessorModel professor = new(nome, sexo, numeroMatricula);

        if (option == "1")
            CadastrarEndereco(professor);

        return professor;
    }

    private static void CadastrarEndereco(ProfessorModel professor)
    {
        string rua = ConsoleExtension.WriteAndRead("rua");
        int numero = int.Parse(ConsoleExtension.WriteAndRead("numero"));
        string cep = ConsoleExtension.WriteAndRead("CEP");

        _ = professor.CadastrarEndereco(new EnderecoModel(rua, numero, cep));
    }
}
