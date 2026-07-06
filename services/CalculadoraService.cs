using System;

namespace Calculadora
{
    class CalculadoraService
    {
        public double Adicao(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public double Subtracao(double a, double b)
        {
            double c = a - b;
            return c;
        }

        public double Divisao(double a, double b)
        {
            double c = a / b;
            return c;
        }

        public double Multiplicacao(double a, double b)
        {
            double c = a * b;
            return c;
        }
    }
}