using atividade.Models;

namespace atividade.Services;
internal class TurmaService
{
    public static TurmaModel Cadastrar()
    {
        do
        {
            string nome = ConsoleExtension.WriteAndRead("Nome");
            string periodo = ConsoleExtension.WriteAndRead("Período");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(periodo))
                ConsoleExtension.Write("Nome e período são obrigatórios", ConsoleColor.Yellow);

            else
            {
                TurmaModel turma = new(nome, periodo);
                FakeDatabase.Turmas.Add(turma);
                return turma;
            }
        } while (true);
    }

    public static void Ver(TurmaModel turma)
    {
        ConsoleExtension.Write(turma.ToString());
    }
}