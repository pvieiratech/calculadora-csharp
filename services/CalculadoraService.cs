using System;

namespace Calculadora.Service
{
    class CalculadoraService
    {
        public static void adicao(double a, double b)
        {
            double c = a + b;
            Console.WriteLine($"A soma entre {a} + {b} = {c}");
        }

        public static void subtracao(double a, double b)
        {
            double c = a - b;
            Console.WriteLine($"A subtração entre {a} - {b} = {c}");
        }

        public static void divisao(double a, double b)
        {
            double c = a / b;
            Console.WriteLine($"A divisão entre {a} e {b} = {c}");
        }

        public static void multiplicacao(double a, double b)
        {
            double c = a * b;
            Console.WriteLine($"A multiplicação entre {a} e {b} = {c}");
        }
    }
}