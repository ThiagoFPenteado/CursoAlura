using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Lista<int> idades = new Lista<int>();
            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);

            int idadeSoma = 0;

            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

            Console.ReadLine();

        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);
            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
            //Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            //Console.WriteLine(SomarVarios(1, 2, 45));
        }
        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contadoGui = new ContaCorrente(111, 1111111);

            //lista.Adicionar(contadoGui);

            //lista.Adicionar(new ContaCorrente(874, 5679787));
            //lista.Adicionar(new ContaCorrente(874, 5679754));
            //lista.Adicionar(new ContaCorrente(874, 5679745));

            //ContaCorrente[] contas = new ContaCorrente[]
            //{
            //contadoGui,
            //new ContaCorrente(874, 5679787),
            //new ContaCorrente(874, 5679754)
            //};

            lista.AdicionarVarios(
                contadoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754),
                new ContaCorrente(874, 5679745)
            );

            //lista.EscreverListaNaTela();
            //lista.Remover(contadoGui);
            //Console.WriteLine("Remover conta Gui");
            //lista.EscreverListaNaTela();

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
            Console.ReadLine();
        }
        //teste somar varios
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaArraydeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438),
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
        static void TestaArrayInt()
        {
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
