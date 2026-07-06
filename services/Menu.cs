using System;

namespace Calculadora
{
    class MenuSystem{
        
        public void BoasVindas()
        {
            Console.WriteLine("Bem-vindo a Calculadora de PvieiraDev ;)");
            Console.WriteLine("Informe qual operação deseja Realizar: ");
            Console.WriteLine("Digite apenas o simbolo");
        }

//verificador de operação
        public string VerificarOperador()
        {
            while(true)
                {
                    Console.WriteLine("+ adição, - subtração, / divisão ou * multiplicação?");
                    string? op = Console.ReadLine();
                    if(op == "+" || op == "-" || op == "/" || op == "*")
                    {
                         return op;
                    }   
                    else
                    {
                        Console.WriteLine("Operador digitado incorretamente");
                            Console.WriteLine("Digite Novamente: ");
                    }
                }
        }

// texto a exibir apos operação
        public void TextAdicao(double a, double b, double c)
        {
            Console.WriteLine($"A soma entre {a} + {b} = {c}");
        }

        public void TextSubtracao(double a, double b, double c)
        {
            Console.WriteLine($"A soma entre {a} - {b} = {c}");
        }

        public void TextDivisao(double a, double b, double c)
        {
            Console.WriteLine($"A soma entre {a} / {b} = {c}");
        }

        public void TextMultiplicacao(double a, double b, double c)
        {
            Console.WriteLine($"A soma entre {a} * {b} = {c}");
        }
    }
}