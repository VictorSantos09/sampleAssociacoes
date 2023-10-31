using atividade.Models;

namespace atividade;
internal static class FakeDatabase
{
    public static List<ProfessorModel> Professores = new();
    public static List<AlunoModel> Alunos = new();
    public static List<TurmaModel> Turmas = new();
    public static List<SalaModel> Salas = new();
    public static List<AulaModel> Aulas = new();
    public static List<CidadeModel> Cidades = new();
    public static List<EnderecoModel> Enderecos = new();
    public static List<MatriculaModel> Matriculas = new();
    public static InstituicaoEnsinoModel InstituicaoEnsino = new("SENAC");
}
