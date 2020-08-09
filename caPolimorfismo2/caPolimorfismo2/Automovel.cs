using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPolimorfismo2
{
    class Automovel : Veiculo
    {
        // atributo
        private int qte_rodas; 

        // metodos
        public Automovel(String _tipo, int _qte_rodas) : base(_tipo)
        {
            qte_rodas = _qte_rodas;
        }

        public override void mover()
        {
            Console.WriteLine("Acelerando o automovel");
        }

        public override void parar()
        {
            Console.WriteLine("Brecando o automovel");
        }
    }
}
