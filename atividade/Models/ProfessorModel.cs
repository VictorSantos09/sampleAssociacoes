namespace atividade.Models;
internal class ProfessorModel
{
    public string Nome { get; set; }
    public string Sexo { get; set; }
    public int NumeroMatricula { get; set; }
    public EnderecoModel? Endereco { get; set; }

    public ProfessorModel(string nome, string sexo, int numeroMatricula)
    {
        Nome = nome;
        Sexo = sexo;
        NumeroMatricula = numeroMatricula;
    }

    public string MostrarDados()
    {
        if (Endereco != null)
        {
            string endereco = $"Cidade: {Endereco.Cidade} - Rua: {Endereco.Rua} - N°{Endereco.Numero} - CEP: {Endereco.CEP}";

            return $"Meu nome é {Nome}, tenho o sexo {Sexo}, meu número de matricula é {NumeroMatricula} e meu endereço é {endereco}";
        }
        return $"Meu nome é {Nome}, tenho o sexo {Sexo}, meu número de matricula é {NumeroMatricula}";
    }

    public bool CadastrarEndereco(EnderecoModel endereco)
    {
        if (endereco is null)
            return false;

        else if (string.IsNullOrEmpty(endereco.Cidade))
            return false;

        else if (endereco.Numero < 0)
            return false;

        else if (string.IsNullOrEmpty(endereco.CEP))
            return false;

        Endereco = endereco;
        return true;
    }
}