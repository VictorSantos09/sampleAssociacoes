namespace atividade.Models;
public class PessoaModel
{
    public int Numero { get; set; }
    public string Sexo { get; set; }

    public PessoaModel(int numero, string sexo)
    {
        Numero = numero;
        Sexo = sexo;
    }
}
