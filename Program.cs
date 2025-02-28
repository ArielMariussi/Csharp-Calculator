using System;
using System.Runtime.Intrinsics;
using System.Security.AccessControl;

namespace Calculadora
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
                case 'a': Console.WriteLine(Adicao(v1, v2)); break;
                case 's': Console.WriteLine(Subtracao(v1, v2)); break;
                case 'm': Console.WriteLine(Multiplicacao(v1, v2)); break;
                case 'd': Console.WriteLine(Divisao(v1, v2)); break;
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
