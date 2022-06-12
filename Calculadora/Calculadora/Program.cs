using System;

namespace Calculadora
    {
    class Calculadora
        {
        public static double Operacao(double valorA, double valorB, string op) {
            double resultado = double.NaN;

            switch (op) {
                case "a":
                resultado = valorA + valorB;
                break;
                case "s":
                resultado = valorA - valorB;
                break;
                case "m":
                resultado = valorA * valorB;
                break;
                case "d":
                if (valorB != 0) {
                    resultado = valorA / valorB;
                    }
                break;
                default:
                break;
                }
            return resultado;
            }
        }
    class Program
        {
        public static void Main(string[] args) {
            bool fimDoPrograma = false;
            Console.WriteLine("Calculadora - DEVin House - Powered by Higor");
            Console.WriteLine("--------------------------------------------");

            while (!fimDoPrograma) {
                string entradaValorA = "";
                string entradaValorB = "";
                double resultado = 0;

                Console.WriteLine("Digite um número, e então pressione enter: ");
                entradaValorA = Console.ReadLine();

                double resetValorA = 0;
                while (!double.TryParse(entradaValorA, out resetValorA)) {
                    Console.WriteLine("Este não é um valor válido. Digite novamente: ");
                    entradaValorA = Console.ReadLine();
                    }

                Console.WriteLine("Digite o segundo número, e então pressione enter: ");
                entradaValorB = Console.ReadLine();

                double resetValorB = 0;
                while (!double.TryParse(entradaValorB, out resetValorB)) {
                    Console.WriteLine("Este não é um valor válido. Digite novamente: ");
                    entradaValorB = Console.ReadLine();
                    }

                Console.WriteLine("Agora, escolha uma operação matemática da lista: ");
                Console.WriteLine("\ta - Adição");
                Console.WriteLine("\ts - Subtração");
                Console.WriteLine("\tm - Multiplicação");
                Console.WriteLine("\td - Divisão");
                Console.WriteLine("Sua opção? ");

                string op = Console.ReadLine();

                try {
                    resultado = Calculadora.Operacao(resetValorA, resetValorB, op);
                    if (double.IsNaN(resultado)) {
                        Console.WriteLine("Esta operação irá acarretar em um erro! \n");

                        }
                    else
                        Console.WriteLine("Seu resultado: {0:0,##}\n", resultado);
                    }
                catch (Exception ex) {
                    Console.WriteLine("Erro fatal! Uma exceção ocorreu durante o processo. \n");
                    }
                Console.WriteLine("--------------------------------------------\n");
                if (Console.ReadLine() == "n") fimDoPrograma = true;

                Console.WriteLine("\n");
                }
            return;
            }
        }
    }