using atividade.Models;

namespace atividade.Services;
internal class AlunoService
{
    public static AlunoModel Cadastrar()
    {
        do
        {
            string nome = ConsoleExtension.WriteAndRead("Nome");
            string sexo = ConsoleExtension.WriteAndRead("Sexo");
            AlunoModel aluno = new(nome, sexo);

            bool result = FormarDupla(aluno);
            if (result)
                return aluno;

            ConsoleExtension.Write("Dupla não é permitida, tente novamente", ConsoleColor.Yellow);
        } while (true);
    }

    private static bool FormarDupla(AlunoModel alunoPrincipal)
    {
        string nome = ConsoleExtension.WriteAndRead("Nome da dupla");
        string sexo = ConsoleExtension.WriteAndRead("Sexo da dupla");
        AlunoModel aluno = new(nome, sexo);

        AlunoModel? duplaFormada = FakeDatabase.Alunos.Find(x => x.AlunoDupla != null && x.AlunoDupla.Nome == nome);
        if (duplaFormada != null)
        {
            Console.WriteLine($"{duplaFormada.Nome} tem dupla com {duplaFormada.AlunoDupla.Nome}. Tente novamente", ConsoleColor.Yellow);
            return false;
        }

        else
        {
            alunoPrincipal.FormarDupla(aluno);
            return true;
        }
    }
}
