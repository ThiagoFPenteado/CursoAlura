using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salario Carlos:" + carlos.Salario);

            Console.WriteLine("Total de Funcionários:"+ Funcionario.TotalDeFuncionarios);
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.648.148-3");
            roberta.Nome = "Roberta";

            roberta.AumentarSalario();
            Console.WriteLine("Novo salario Roberta:" + roberta.Salario);

            Console.WriteLine("Total de Funcionários:" + Funcionario.TotalDeFuncionarios);

            //Funcionario _robertaTeste = roberta;
            //Console.WriteLine("Bonificador de um referencia de Diretor:" + roberta.GetBonificacao());
            //Console.WriteLine("Bonificador de um referencia de Funcionario:" + _robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine("Bonificação:" + carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Bonificação:" + roberta.GetBonificacao());

            Console.WriteLine("Total e bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
