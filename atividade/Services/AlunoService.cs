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
            int numero = int.Parse(ConsoleExtension.WriteAndRead("Numero do aluno"));

            MatriculaModel matricula = MatriculaService.Criar();

            AlunoModel aluno = new(nome, sexo, matricula, numero);

            bool isDplaFormada = FormarDupla(aluno);
            if (isDplaFormada)
            {
                FakeDatabase.Alunos.Add(aluno);
                return aluno;
            }

            ConsoleExtension.Write("Dupla não é permitida, tente novamente", ConsoleColor.Yellow);
        } while (true);
    }

    private static bool FormarDupla(AlunoModel alunoPrincipal)
    {
        string nome = ConsoleExtension.WriteAndRead("Nome");
        string sexo = ConsoleExtension.WriteAndRead("Sexo");
        int numero = int.Parse(ConsoleExtension.WriteAndRead("Numero do aluno"));

        MatriculaModel matricula = MatriculaService.Criar();

        AlunoModel aluno = new(nome, sexo, matricula, numero);

        AlunoModel? duplaFormada = FakeDatabase.Alunos.Find(x => x.AlunoDupla != null && x.AlunoDupla.Nome == aluno.Nome);
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
