using atividade.Models;

namespace atividade.Services;
internal class TurmaService
{
    public static TurmaModel Cadastrar()
    {
        do
        {
            string nome = ConsoleExtension.WriteAndRead("Nome");
            string periodo = ConsoleExtension.WriteAndRead("Periodo");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(periodo))
            {
                ConsoleExtension.Write("Nome e periodo são obrigatórios", ConsoleColor.Yellow);
            }
            else
            {
                return new TurmaModel(nome, periodo);
            }
        } while (true);
    }

    public static void Ver(TurmaModel turma)
    {
        ConsoleExtension.Write(turma.ToString());
    }
}