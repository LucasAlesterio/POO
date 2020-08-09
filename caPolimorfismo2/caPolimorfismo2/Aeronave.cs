using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPolimorfismo2
{
    class Aeronave : Veiculo
    {
        // atributo
        private int qte_turbinas;

        // metodos
        public Aeronave(String _tipo, int _qte_turbinas) : base(_tipo)
        {
            qte_turbinas = _qte_turbinas;
        }

        public override void mover()
        {
            Console.WriteLine("Acelerando a aeronave");
        }

        public override void parar()
        {
            Console.WriteLine("Brecando a aeronave");
        }
    } // fim da classe Aeronave
}
