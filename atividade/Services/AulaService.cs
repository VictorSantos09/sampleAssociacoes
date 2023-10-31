using atividade.Models;

namespace atividade.Services;
internal class AulaService
{
    public static AulaModel Criar()
    {
        SalaModel sala = SalaService.Cadastrar();
        TurmaModel turma = TurmaService.Cadastrar();
        ProfessorModel professor = ProfessorService.Cadastrar();

        AulaModel aula = new(sala, turma, professor);

        FakeDatabase.Aulas.Add(aula);
        ConsoleExtension.Write("Aula criada com sucesso", ConsoleColor.Green);
        return aula;
    }

    public static void Ver(AulaModel aula)
    {
        ConsoleExtension.Write(aula.ToString());
    }
}