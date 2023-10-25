namespace atividade.Models;
internal class MatriculaModel
{
    public int Numero { get; set; }
    public DateTime Data { get; set; }

    public MatriculaModel(int numero, DateTime data)
    {
        Numero = numero;
        Data = data;
    }
}
