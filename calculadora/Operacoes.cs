using System.ComponentModel.DataAnnotations;

namespace Operacoes
{
    public class Calculos
    {
        public static void soma(
            Decimal Valor1,
            Decimal Valor2
        )
        {
            Facilitador.Loading(2);
            Console.WriteLine($"O resultado da soma de {Valor1} e {Valor2} é {Valor1+Valor2}");
        }
        public static void Subtração(
            Decimal Valor1,
            Decimal Valor2
        )
        {
            Facilitador.Loading(2);
            Console.WriteLine($"O resultado da subtração de {Valor1} e {Valor2} é {Valor1-Valor2}");
        }
        public static void Multiplicação(
            Decimal Valor1,
            Decimal Valor2
        )
        {
            Facilitador.Loading(2);
            Console.WriteLine($"O resultado da multiplicação de {Valor1} e {Valor2} é {Valor1*Valor2}");
        }
        public static void Divizão(
            Decimal Valor1,
            Decimal Valor2
        )
        {
            Facilitador.Loading(2);
            Console.WriteLine($"O resultado da divizão de {Valor1} e {Valor2} é {Valor1/Valor2}");
        }
        public static void Potenciação(
            Double Valor1,
            Double Valor2
        )
        {
            Double resultado = Math.Pow(Valor1,Valor2);
            Facilitador.Loading(2);
            Console.WriteLine($"O resultado da potenciação de {Valor1} e {Valor2} é {resultado}");
        }
    }
    public class Facilitador
    {
        public static decimal ValorDecimal(int ordinal)
        {
            return1:
            Console.Clear();
            Console.Write($"Escreva o {ordinal}º valor numerico: ");
            if(!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor invalido!!");
                Thread.Sleep(1500);
                Console.ResetColor();
                goto return1;
            }

            return valor;
        }
        public static Double ValorDouble(int ordinal)
        {
            return1:
            Console.Clear();
            Console.Write($"Escreva o {ordinal}º valor numerico: ");
            if(!Double.TryParse(Console.ReadLine(), out Double valor))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor invalido!!");
                Thread.Sleep(1500);
                Console.ResetColor();
                goto return1;
            }

            return valor;
        }
        public static void Pausa()
        {
            Console.WriteLine();
            Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();

        }
        public static void Loading(
            int Tempo
        )
        {

            for(int i = 0; i<=Tempo-1; i++)
            {
                Console.Clear();
                Console.WriteLine("Loading.");
                Thread.Sleep(333);
                Console.Clear();
                Console.WriteLine("Loading..");
                Thread.Sleep(333);
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(333);
            }
            Console.Clear();
        }
    }
}