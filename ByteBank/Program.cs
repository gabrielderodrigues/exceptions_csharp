using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Ocorreu um Erro Interno!");
            }
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(2);
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}
