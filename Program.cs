using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;
            
            Console.Write("Primeiro numero: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Segundo numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            int soma = primeiroNumero + segundoNumero;
            Console.WriteLine();
            Console.WriteLine($"O resultado é: {soma}");
        }
    }
}