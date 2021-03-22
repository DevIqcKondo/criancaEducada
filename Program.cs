using System;

namespace criancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.Write("Vamos fazer um teste? ");
            Console.Write("Tecle ENTER para iniciar. ");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Vamos lá, digite alguma frase.");
            Console.ForegroundColor=ConsoleColor.White;
            string frase = Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine(frase=frase.Replace("a","@").Replace("e","&").Replace("i","1").Replace("o","#").Replace("u","*"));
            Console.ResetColor();
            
     }
    }
}
