//using Microsoft.EntityFrameworkCore.ChangeTracking;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Alura.Loja.Testes.ConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using (var contexto = new LojaContext())
//            {
//                //mostra os Comandos SQL que o Entity cria
//                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
//                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
//                loggerFactory.AddProvider(SqlLoggerProvider.Create());

//                var produtos = contexto.Produtos.ToList();

//                ExibeEntries(contexto.ChangeTracker.Entries());


//                var novoProduto = new Produto()
//                {
//                    Nome = "Sabão em pó",
//                    Categoria = "Limpeza",
//                    Preco = 4.99
//                };
//                contexto.Produtos.Add(novoProduto);
//                ExibeEntries(contexto.ChangeTracker.Entries());
//                //var p1 = produtos.Last();
//                contexto.Produtos.Remove(novoProduto);

//                ExibeEntries(contexto.ChangeTracker.Entries());
//                //contexto.SaveChanges();
//                var entry  = contexto.Entry(novoProduto);
//                Console.WriteLine("\n\n" + entry.Entity.ToString() + " - " + entry.State);
//                //ExibeEntries(contexto.ChangeTracker.Entries());
//            }
//        }

//        private static void ExibeEntries(IEnumerable<EntityEntry> enumerable)
//        {
//            Console.WriteLine("=================");
//            foreach (var b in enumerable)
//            {
//                Console.WriteLine(b.Entity.ToString() + " - " + b.State);
//            }
//        }
//    }
//}

//// comentarios {
////foreach (var p in produtos)
////{
////  Console.WriteLine(p);
////}
////var p1 = produtos.Last();
////p1.Nome = "007 - O Espiao Que Me Amava - editado";

////var novoProduto = new Produto()
////{
//// Nome = "Desinfetante",
////Categoria = "Limpeza",
////Preco = 2.99
////};
////contexto.Produtos.Add(novoProduto);

////foreach (var p in produtos)
////{
////    Console.WriteLine(p);
////}
////}