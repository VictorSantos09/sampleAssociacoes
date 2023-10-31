namespace atividade.Models;
public class InstituicaoEnsinoModel
{
    public string Nome { get; set; }
    public List<ProfessorModel> Professores { get; set; }

    public InstituicaoEnsinoModel(string nome)
    {
        Nome = nome;
        Professores = new();
    }

    public void AdicionarProfessor(ProfessorModel professor)
    {
        Professores.Add(professor);
    }

    public void RemoverProfessor(ProfessorModel professor)
    {
        _ = Professores.Remove(professor);
    }

    public float Faturamento(List<DespesaModel> despesas, List<ReceitaModel> receitas)
    {
        float totalDespesas = despesas.Sum(despesa => despesa.Valor);
        float totalReceitas = receitas.Sum(receita => receita.Valor);

        float resultado = totalReceitas - totalDespesas;
        return resultado;
    }
}
