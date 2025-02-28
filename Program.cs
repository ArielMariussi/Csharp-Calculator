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
            Console.WriteLine("a => ADICAO");
            Console.WriteLine("s => SUBTRACAO");
            Console.WriteLine("m => MULTIPLICACAO");
            Console.WriteLine("d => DIVISAO");
            char type = char.Parse(Console.ReadLine());

            switch (type)
            {
                case 'a': Console.WriteLine("A soma desses numeros é igual a:" + Adicao(v1, v2)); break;
                case 's': Console.WriteLine("A diferenca entre esses numeros é igual a:" + Subtracao(v1, v2)); break;
                case 'm': Console.WriteLine("A multiplicacao entre esses numeros e igual a: " + Multiplicacao(v1, v2)); break;
                case 'd': Console.WriteLine("A divisao entre esses numeros e igual a: " + Divisao(v1, v2)); break;
            }
        }

        static float Adicao(float v1, float v2)
        {
            return v1 + v2;
        }

        static float Subtracao(float v1, float v2)
        {
            return v1 - v2;
        }

        static float Multiplicacao(float v1, float v2)
        {
            return v1 * v2;
        }

        static float Divisao(float v1, float v2)
        {
            return v1 / v2;
        }
    }
}
