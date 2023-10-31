using atividade.Models;

namespace atividade.Services;
internal class ProfessorService
{
    public static ProfessorModel Cadastrar()
    {
        string nome = ConsoleExtension.WriteAndRead("Nome");
        string sexo = ConsoleExtension.WriteAndRead("Sexo");
        int numeroMatricula = int.Parse(ConsoleExtension.WriteAndRead("Numero da matricula"));
        int numero = int.Parse(ConsoleExtension.WriteAndRead("Nº do professor"));

        string opcao = ConsoleExtension.WriteAndRead("Deseja cadastrar o endereço?\n 1 - SIM\n 2 - NÃO");

        ProfessorModel professor = new(nome, sexo, numeroMatricula, numero);

        if (opcao == "1")
            CadastrarEndereco(professor);

        FakeDatabase.Professores.Add(professor);
        return professor;
    }

    private static void CadastrarEndereco(ProfessorModel professor)
    {
        EnderecoModel endereco = EnderecoService.Criar();
        _ = professor.CadastrarEndereco(endereco);
    }
}
