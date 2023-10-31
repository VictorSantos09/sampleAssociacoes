namespace atividade;
internal static class ConsoleExtension
{
    public static string WriteAndRead(string message, bool uppercase = true)
    {
        Write(message, uppercase: uppercase);
        return Read();
    }

    public static string Read()
    {
        do
        {
            Console.Write("DIGITE: ");
            string? text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
                Write("Digite algo válido", ConsoleColor.Red);

            else
                return text;
        } while (true);
    }

    public static void Write(string message, ConsoleColor color = ConsoleColor.White, bool uppercase = true)
    {
        Console.ForegroundColor = color;
        if (uppercase)
            Console.WriteLine(message.ToUpper());

        else
            Console.WriteLine(message);

        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Clear()
    {
        Console.Clear();
    }

    public static void Sleep(int milliseconds = 750)
    {
        Thread.Sleep(milliseconds);
    }
}
