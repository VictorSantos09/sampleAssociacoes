namespace atividade.Models;
public class ReceitaModel
{
    public string Tipo { get; set; }
    public float Valor { get; set; }

    public ReceitaModel(string tipo, float valor)
    {
        Tipo = tipo;
        Valor = valor;
    }

}
