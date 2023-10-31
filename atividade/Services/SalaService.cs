using atividade.Models;

namespace atividade.Services;
internal class SalaService
{
    public static SalaModel Cadastrar()
    {
        do
        {
            string nome = ConsoleExtension.WriteAndRead("Nome");
            int capacidade = int.Parse(ConsoleExtension.WriteAndRead("Capacidade"));
            SalaModel sala = new(nome, capacidade);

            if (capacidade > 0 && string.IsNullOrEmpty(nome) == false)
            {
                FakeDatabase.Salas.Add(sala);
                return sala;
            }

            ConsoleExtension.Write("Nome deve ser válido e capacidade maior do que 0", ConsoleColor.Yellow);
        } while (true);
    }

    public static void Ver(SalaModel sala)
    {
        ConsoleExtension.Write(sala.ToString());
    }
}
