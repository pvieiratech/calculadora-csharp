using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using Calculadora;

namespace Calculadora
{
    class Program 
    {
        public static void Main()
        {
            CalculadoraService calculadora = new CalculadoraService();
            MenuSystem menu = new MenuSystem();

            menu.BoasVindas();           
            string? operador;
            string? continuar = "s";
               
            while(true)
            {
                if(continuar == "s")
                {
                    operador = menu.VerificarOperador();

                    double numero1 = valores("Digite o primeiro número:");
                    double numero2 = valores("Digite o segundo número");

                    while (true)
                    {
                        if(operador == "/" && numero2 == 0)
                        {
                            Console.WriteLine("Não é possivel realizar uma divisão por 0");
                            numero2 = valores("Digite um valor valido: ");
                        } 
                        else
                        {
                            break;
                        }
                    }

                    switch (operador)
                    {
                        case "+":
                        menu.TextAdicao(numero1, numero2, calculadora.Adicao(numero1, numero2));
                        break;

                        case "-":
                        menu.TextSubtracao(numero1, numero2, calculadora.Subtracao(numero1, numero2));
                        break;

                        case "/":
                        menu.TextDivisao(numero1, numero2, calculadora.Divisao(numero1, numero2));
                        break;

                        case "*":
                        menu.TextMultiplicacao(numero1, numero2, calculadora.Multiplicacao(numero1, numero2));
                        break;
                    }

                    Console.WriteLine("Deseja realizar outra conta? (s/n)");
                    continuar =Console.ReadLine();
                } 
                else
                {
                    break;
                }    
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
