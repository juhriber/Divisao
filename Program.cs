using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;

            Console.ForegroundColor = ConsoleColor.DarkYellow;  
            Console.Write("Digite o 1ºValor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;  
            Console.Write("Digite o 2ºValor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine();
            Console.ResetColor();

            
            
            if(valor2 != 0)
            {
                valor3 = valor1 / valor2;
                
                Console.WriteLine($"{valor1} dividido por {valor2} é = {valor3}");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ResetColor();  
                Console.WriteLine("Não é possivel dividir por zero");
                Console.WriteLine();
            }
        }
    }
}   
