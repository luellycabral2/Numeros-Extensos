using System;
using Humanizer;

namespace Numeros_Extensos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            string Palavra;

            Console.Write("Digite um Numero: ");
            Numero = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Palavra = Numero.ToWords();
            Console.WriteLine("Seu numero em palavras");
            Console.WriteLine(Palavra);
        }
    }
}
