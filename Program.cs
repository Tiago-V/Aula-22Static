using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Conversor.ValorDolar = 5.3f; //Quantia de Reais para um dolar
            Conversor.ValorEuro = 5.9f; //Quantia de Reais para um Euro
            Console.WriteLine( Conversor.EuroToReal(10)+"R$" );
            Console.WriteLine( Conversor.RealToEuro(59)+"EU" );
            
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine( Conversor.DolarToReal(10)+"R$" );
            Console.WriteLine( Conversor.RealToDolar(53)+"US" );

        }
    }
}
