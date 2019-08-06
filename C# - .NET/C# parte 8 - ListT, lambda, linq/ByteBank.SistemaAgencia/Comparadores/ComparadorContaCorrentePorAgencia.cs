using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null )
            {
                return 1;
            }

            if (x == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);

            //X fica na frente
            //if (x.Agencia < y.Agencia)
            //{
                //return -1;
            //}
            //equivalente
            //if (x.Agencia == y.Agencia)
            //{
                //return 0;
            //}
            //y fica na frente
            //return 1;
        }
    }
}
