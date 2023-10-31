namespace atividade.Models;
public class DespesaModel
{
    public float Valor { get; set; }
    public string Tipo { get; set; }

    public DespesaModel(float valor, string tipo)
    {
        Valor = valor;
        Tipo = tipo;
    }
}
