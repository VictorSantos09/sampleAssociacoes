using atividade.Models;

namespace atividade;
internal class FakeDatabase
{
    public static List<ProfessorModel> Professores = new()
    {
        new ProfessorModel("Alan", "M", 3)
        {
            Endereco = new ("Bolivia", 78, "78524354")
        }
    };

    public static List<AlunoModel> Alunos = new()
    {
         new("Victor", "M")
         {
             AlunoDupla = new("Valdiclei", "M")
         }
    };

    public static List<TurmaModel> Turmas = new()
    {
        new("ADS 2º FASE", "Noturno")
    };

    public static List<SalaModel> Salas = new()
    {
        new("Sala 201", 60)
    };

    public static List<AulaModel> Aulas = new()
    {
        new(Salas.ElementAt(0),Turmas.ElementAt(0), Professores.ElementAt(0))
    };

    public static InstituicaoEnsinoModel InstituicaoEnsino = new("SENAC");
}
