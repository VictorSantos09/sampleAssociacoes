using atividade.Models;

namespace atividade;
internal class FakeDatabase
{
    public static List<ProfessorModel> Professores = new List<ProfessorModel>()
    {
        new ProfessorModel("Alan", "M", 3)
        {
            Endereco = new EnderecoModel("Bolivia", 78, "Blumenau", "78524354")
        }
    };

    public static List<AlunoModel> Alunos = new List<AlunoModel>()
    {
         new("Victor", "M")
         {
             AlunoDupla = new("Valdiclei", "M")
         }
    };

    public static InstituicaoEnsinoModel InstituicaoEnsino;
}
