using atividade.Models;

namespace atividade.Services;
internal class AlunoService
{
    public static AlunoModel Cadastrar(List<AlunoModel> alunosCadastrados)
    {
        do
        {
            var nome = ConsoleExtension.WriteAndRead("Nome");
            var sexo = ConsoleExtension.WriteAndRead("Sexo");
            AlunoModel aluno = new(nome, sexo);

            var result = FormarDupla(aluno, alunosCadastrados);
            if (result)
                return aluno;

            ConsoleExtension.Write("Dupla não é permitida, tente novamente", ConsoleColor.Yellow);
        } while (true);
    }

    private static bool FormarDupla(AlunoModel alunoPrincipal, List<AlunoModel> alunosCadastrados)
    {
        var nome = ConsoleExtension.WriteAndRead("Nome da dupla");
        var sexo = ConsoleExtension.WriteAndRead("Sexo da dupla");
        AlunoModel aluno = new(nome, sexo);

        var duplaFormada = alunosCadastrados.Find(x => x.AlunoDupla != null && x.AlunoDupla.Nome == nome);
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
