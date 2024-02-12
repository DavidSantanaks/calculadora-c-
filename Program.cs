using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {

            Menu();
        }

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("5- Area");
            Console.WriteLine("6- Sair da aplicção");

            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Area(); break;
                case 6: Exit(); break;
                default: Menu(); break;
            }

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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
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
            Console.ReadKey();
            Menu();
        }

        static void Area()
        {
            Console.WriteLine("Digite o valor do comprimento:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da largura:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O tamanho da area é de {resultado} M");
            Console.ReadKey();
            Menu();
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Saindo da aplicação ");
            System.Environment.Exit(0);
        }
    }
}