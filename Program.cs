using System;
using System.Globalization;
using Calculadora.Service;

namespace Calculadora
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Bem-vindo a Calculadora de PvieiraDev ;)");
            Console.WriteLine("Informe qual operação deseja Realizar: ");
            Console.WriteLine("Digite apenas o simbolo");
            string? operador;
               

            while(true)
            {
                Console.WriteLine("+ adição, - subtração, / divisão ou * multiplicação?");
                operador = Console.ReadLine();
                if(operador == "+" || operador == "-" || operador == "/" || operador == "*")
                {
                    break;
                }   else
                {
                    Console.WriteLine("Operador digitado incorretamente");
                    Console.WriteLine("Digite Novamente: ");
                }
            }



            double numero1 = valores("Digite o primeiro número:");
            double numero2 = valores("Digite o segundo número"); 

            switch (operador)
            {
                case "+":
                Calculadora.Service.CalculadoraService.adicao(numero1, numero2);
                break;

                case "-":
                Calculadora.Service.CalculadoraService.subtracao(numero1, numero2);
                break;

                case "/":
                Calculadora.Service.CalculadoraService.divisao(numero1, numero2);
                break;

                case "*":
                Calculadora.Service.CalculadoraService.multiplicacao(numero1, numero2);
                break;
            }
        }

        public static double valores(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string? texto = Console.ReadLine();

                if (double.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out double numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Número inválido, digite novamente:");
                }
            }
        }
    }
}
