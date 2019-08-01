using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá, mundo!");
            //Console.WriteLine(123);
            //Console.WriteLine(10.5);
            //Console.WriteLine(true);

            //object conta = new ContaCorrente(456, 687876);
            //object desenvolvedor = new Desenvolvedor("4564654");

            //string contaToString = conta.ToString();

            //Console.WriteLine("Resultado: " + contaToString);
            //Console.WriteLine(conta);
            //Console.WriteLine(desenvolvedor);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.ReadLine();
        }



        static void TestaString() {
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 47844546";
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            //string urlTeste = "https://www.bytebank.com/cambio";
            //int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            //Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            //Console.WriteLine(urlTeste.EndsWith("cambio"));

            //Console.WriteLine(urlTeste.Contains("bytebank"));

            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaOrigem: " + valor);
            //string valor2 = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor2);
            //string valor3 = extratorDeValores.GetValor("valor");
            //Console.WriteLine("Valor de valor: " + valor3);

            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";
            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            //Console.WriteLine(termoBusca.ToUpper());
            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca.ToUpper()));

            Console.ReadLine();

            //string palavra = "moedaOrigem=real&moedaDestino=dolar";
            //string nomeArgumento = "moedaDestino=";

            //int indice = palavra.IndexOf(nomeArgumento);
            //Console.WriteLine(indice);

            //Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            //Console.WriteLine(palavra);
            //Console.WriteLine(palavra.Substring(indice));
            //Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
        }
    }
}
