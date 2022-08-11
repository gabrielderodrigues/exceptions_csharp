using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarregarContas();
           
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = null;

            try
            {
                leitor = new LeitorDeArquivos("contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            }
            finally
            {
                // finally vai ser executado sempre, independente dar resposta do try e do catch.
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(454, 55555);
                ContaCorrente conta2 = new ContaCorrente(455, 66666);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(2);
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
