using atividade.Models;

namespace atividade.Services;
public static class MatriculaService
{
    public static MatriculaModel Criar()
    {
        int numero = int.Parse(ConsoleExtension.WriteAndRead("Número da matricula"));
        DateTime data = DateTime.Parse(ConsoleExtension.WriteAndRead("Data da matricula"));
        var resultado = new MatriculaModel(numero, data);
        return resultado;
    }
}
