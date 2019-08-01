using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste ()
        {       
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
        }

    }
    public class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }
    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {

        }
        private void MetodoPrivado()
        {

        }
        protected void MetodoProtegido()
        {

        }
        internal void MetodoInterno()
        {

        }
    }
}
