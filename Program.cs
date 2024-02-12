using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {

            //Soma();
            //Subtracao();
            //Divisao();
            //Multiplicacao();


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");

            //Convertendo texto para float
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é: {resultado}");
        }

        static void Subtracao()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor:");

            //Convertendo texto para float
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine();
            Console.WriteLine($"O resultado da subtração é: {resultado}");
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"\nO valor da divisão é: {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"\nO resultado é: {resultado}");
        }
    }
}