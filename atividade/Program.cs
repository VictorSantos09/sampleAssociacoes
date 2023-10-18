using atividade;
using atividade.Models;
using atividade.Services;

do
{
    try
    {
        bool rodar = Menu();
        if (rodar == false)
            break;
    }
    catch (Exception ex)
    {
        ConsoleExtension.Write(ex.Message, ConsoleColor.Red);
        throw;
    }
} while (true);


bool Menu()
{
    ConsoleExtension.Clear();
    ConsoleExtension.Write("0 - Sair");
    ConsoleExtension.Write("1 - Cadastrar Aluno");
    ConsoleExtension.Write("2 - Cadastrar Professor");
    ConsoleExtension.Write("3 - Ver Alunos");
    ConsoleExtension.Write("4 - Ver Professores");
    ConsoleExtension.Write("------------------------------------------");

    ConsoleExtension.Write("INSTITUIÇÃO DE ENSINO");
    ConsoleExtension.Write("5 - Adicionar Professor");
    ConsoleExtension.Write("6 - Remover Professor");
    int option = int.Parse(ConsoleExtension.Read());

    switch (option)
    {
        case 0:
            return false;
        case 1:
            FakeDatabase.Alunos.Add(AlunoService.Cadastrar());
            break;
        case 2:
            FakeDatabase.Professores.Add(ProfessorService.Cadastrar());
            break;
        case 3:
            verAlunos();
            break;
        case 4:
            VerProfessores();
            break;
        case 5:
            InstituicaoEnsinoService.AdicionarProfessor(ConsoleExtension.WriteAndRead("Nome do professor a ser adicionado"));
            break;
        case 6:
            InstituicaoEnsinoService.AdicionarProfessor(ConsoleExtension.WriteAndRead("Nome do professor a ser removido"));
            break;
        default:
            ConsoleExtension.Write("opção inválida, tente novamente", ConsoleColor.Red);
            break;
    }
    return true;
}

void VerProfessores()
{
    ConsoleExtension.Clear();
    foreach (ProfessorModel p in FakeDatabase.Professores)
    {
        ConsoleExtension.Write(p.MostrarDados());
    }
}

void verAlunos()
{
    ConsoleExtension.Clear();
    foreach (AlunoModel a in FakeDatabase.Alunos)
    {
        ConsoleExtension.Write(a.ToString());
    }
}