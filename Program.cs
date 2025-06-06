using System;

class Program
{
    static void Main(string[] args)
    {
        string sair = "tchau";
        string p = "";

        Console.WriteLine("- groot bot -");

        while (p != sair)
        {
            Console.Write("pergunta: ");
            p = Console.ReadLine();

            if (p.Trim().ToLower() == sair)
            {
                Console.WriteLine("eu sou groot!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("resposta: eu sou groot.");
                Console.ResetColor();
            }
        }

   
    }
}
