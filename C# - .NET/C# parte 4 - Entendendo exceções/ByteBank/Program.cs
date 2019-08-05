using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN!");
            }
            Console.WriteLine("Tecle enter pra sair!");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using(LeitorDeArquivos leitor = new LeitorDeArquivos("Conta.txt"))
            {
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("Conta.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capiturada e tratada");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
 
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 874150);
                ContaCorrente conta2 = new ContaCorrente(485, 456578);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine();
                Console.WriteLine("informções da Inner Exception:");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 874150);
            //    ContaCorrente conta2 = new ContaCorrente(485, 456578);

            //    conta2.Transferir(10000,conta);
            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(500);

            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine("Argumento com problema: " + e.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            //    Console.WriteLine(e.Message);
            //}
            //catch (SaldoInsuficienteException e)
            //{
            //    Console.WriteLine(e.Saldo);
            //    Console.WriteLine(e.ValorSaque);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException ");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);

            //}

            ////Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}
