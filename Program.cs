using System;

namespace CalculadoraTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaValor();
        }

        private static void CalculaValor()
        {            
            int operacao;

            do
            {
                while (true)
                {
                    Console.Write("1 - Soma\r\n" +
                    "2 - Subtração\r\n" +
                    "3 - Multiplicação\r\n" +
                    "4 - Divisão\r\n" +
                    "0 - Desligar a Calculadora\r\n" +
                    "\r\nEscolha uma operação: ");

                    if (int.TryParse(Console.ReadLine(), out operacao) && operacao >= 0 && operacao <= 4)
                    {
                        if (operacao != 0)
                        {
                            Console.Write("Insira o primeiro número: ");

                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Insira o segundo número: ");
                            int y = int.Parse(Console.ReadLine());

                            switch (operacao)
                            {
                                case 1:
                                    Console.WriteLine("Resultado: " + (x + y) + "\r\n");
                                    break;
                                case 2:
                                    Console.WriteLine("Resultado: " + (x - y) + "\r\n");
                                    break;
                                case 3:
                                    Console.WriteLine("Resultado: " + (x * y) + "\r\n");
                                    break;
                                case 4:
                                    Console.WriteLine("Resultado: " + (x / y) + "\r\n");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("A Calculadora Foi Desligada.");
                        }
                        break;
                    }
                    Console.WriteLine("Operação Inválida!!\r\n");
                }
            }
            while (operacao != 0);
        }
    }
}
