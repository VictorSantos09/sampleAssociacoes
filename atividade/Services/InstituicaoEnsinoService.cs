using atividade.Models;

namespace atividade.Services;
internal class InstituicaoEnsinoService
{
    public static void AdicionarProfessor(string nome)
    {
        ProfessorModel? professor = FakeDatabase.Professores.Find(x => x.Nome == nome);
        if (professor is null)
        {
            ConsoleExtension.Write("Professor não encontrado", ConsoleColor.Yellow);
        }
        else
        {
            FakeDatabase.InstituicaoEnsino.AdicionarProfessor(professor);
        }
    }

    public static void RemoverProfessor(string nome)
    {
        ProfessorModel? professor = FakeDatabase.Professores.Find(x => x.Nome == nome);
        if (professor is null)
        {
            ConsoleExtension.Write("Professor não encontrado", ConsoleColor.Yellow);
        }
        else
        {
            FakeDatabase.InstituicaoEnsino.RemoverProfessor(professor);
        }
    }
}
