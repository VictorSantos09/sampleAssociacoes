using atividade.Models;

namespace atividade.Services;
internal class ProfessorService
{
    public static ProfessorModel Cadastrar()
    {
        var nome = ConsoleExtension.WriteAndRead("Nome");
        var sexo = ConsoleExtension.WriteAndRead("Sexo");
        var numeroMatricula = int.Parse(ConsoleExtension.WriteAndRead("Numero da matricula"));

        var option = ConsoleExtension.WriteAndRead("Deseja cadastrar o endereço?\n 1 - SIM\n 2 - NÃO");

        ProfessorModel professor = new(nome, sexo, numeroMatricula);

        if (option == "1")
            CadastrarEndereco(professor);

        return professor;
    }

    private static void CadastrarEndereco(ProfessorModel professor)
    {
        var rua = ConsoleExtension.WriteAndRead("rua");
        var numero = int.Parse(ConsoleExtension.WriteAndRead("numero"));
        var cidade = ConsoleExtension.WriteAndRead("cidade");
        var cep = ConsoleExtension.WriteAndRead("CEP");

        professor.CadastrarEndereco(new EnderecoModel(rua, numero, cidade, cep));
    }
}
