using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //CriarArquivo();
            //CriarArquivoComWriter();
            //EscritaBinaria();
            //LeituraBinaria();

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");
            UsarStreamDeEntrada();
            Console.WriteLine("Aplicação finalizada");
            Console.ReadLine();
        }
    }
} 
 