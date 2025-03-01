using System;
using System.Runtime.Intrinsics;
using System.Security.AccessControl;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("---Calculadora---");
            Console.WriteLine("Entre com um valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com outro valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o tipo de operacao que deseja efetuar:");
            Console.WriteLine("1 => ADICAO");
            Console.WriteLine("2 => SUBTRACAO");
            Console.WriteLine("3 => MULTIPLICACAO");
            Console.WriteLine("4 => DIVISAO");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1: Adicao(v1, v2); break;
                case 2: Subtracao(v1, v2); break;
                case 3: Multiplicacao(v1, v2); break;
                case 4: Divisao(v1, v2); break;
            }
        }

        static void Adicao(float v1, float v2)
        {
            float resultado = v1 + v2;
            Console.WriteLine("A soma desses numeros é igual a:" + resultado);
            Console.ReadKey();
            Console.Clear();
            Menu();



        }

        static void Subtracao(float v1, float v2)
        {
            float resultado = v1 - v2;

            Console.WriteLine("A diferenca entre esses numeros é igual a:" + resultado);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Multiplicacao(float v1, float v2)
        {
            float resultado = v1 * v2;

            Console.WriteLine("A multiplicacao entre esses numeros e igual a:" + resultado);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void Divisao(float v1, float v2)
        {
            float resultado = v1 / v2;

            Console.WriteLine("A divisao entre esses numeros e igual a: " + resultado);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
