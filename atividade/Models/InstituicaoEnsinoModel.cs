namespace atividade.Models;
internal class InstituicaoEnsinoModel
{
    public string Nome { get; set; }
    public List<ProfessorModel> Professores { get; set; } = new();

    public InstituicaoEnsinoModel(string nome)
    {
        Nome = nome;
    }

    public void AdicionarProfessor(ProfessorModel professor)
    {
        Professores.Add(professor);
    }

    public void RemoverProfessor(ProfessorModel professor)
    {
        _ = Professores.Remove(professor);
    }
}
