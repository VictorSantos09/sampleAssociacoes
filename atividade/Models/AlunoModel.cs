namespace atividade.Models;
public class AlunoModel : PessoaModel
{
    public string Nome { get; set; }
    public AlunoModel AlunoDupla { get; set; }
    public MatriculaModel Matricula { get; set; } 

    public AlunoModel(string nome, string sexo, MatriculaModel matricula, int numero) : base(numero, sexo) 
    {
        Nome = nome;
        Sexo = sexo;
        Matricula = matricula;
    }

    public override string? ToString()
    {
        return $"Meu nome é '{Nome}' tenho o sexo '{Sexo}' e minha dupla é '{AlunoDupla.Nome}' do sexo '{AlunoDupla.Sexo}'";
    }

    public void FormarDupla(AlunoModel aluno)
    {
        AlunoDupla = aluno;
    }

    public string NomeDupla()
    {
        return $"Dupla: {Nome} - {AlunoDupla.Nome}";
    }
}
