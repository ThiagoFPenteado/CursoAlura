using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            var contas = new List<ContaCorrente>()
            {
                    new ContaCorrente(341, 1),
                    new ContaCorrente(342, 999),
                    null,
                    new ContaCorrente(340, 4),
                    new ContaCorrente(340, 456),
                    new ContaCorrente(340, 10),
                    null,
                    null,
                    new ContaCorrente(290, 123)
            };

            //contas.Sort(); - Chama a implementação dada em IComparable
            //contas.Sort(new ComparadorContaCorrentePorAgencia());
            //contas.OrderBy(conta => conta.Numero);
            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = 
            //contas.OrderBy(conta => {
            //if (conta == null)
            //{
            //    return int.MaxValue;
            //}
            //return conta.Numero;
            //});

            //removendo nulos versão 1
            //var listaSemNulos = new List<ContaCorrente>();
            //foreach (var conta in contas)
            //{
            //if(conta != null)
            //{
            //listaSemNulos.Add(conta);
            //}
            //}

            //removendo nulos versão 2

            // Where e OrderBy separados
            //var contasNãoNulas = contas.Where(conta => conta != null);
            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contasNãoNulas.OrderBy(conta => conta.Numero);

            // Where e OrderBy juntos
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy<ContaCorrente, int>(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                //if(conta != null)
                //{
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                //}
            }

            Console.ReadLine();

        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Guilherme",
                "Luana",
                "Ana"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            //idades.Remove(5);

            idades.AdicionarVarios(45, 89, 12);
            idades.AdicionarVarios(99, -1);
            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
