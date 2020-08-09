using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2_P1
{
    class Saude : Pagtos
    {
        private String estabelecimento;
        private double vlfatSaude;
        private Saude() : base()
        {
            estabelecimento = "";
            vlfatSaude = 0;
            cpf = 0;
            valor = 0;
            code = 0;

        }

        public Saude(long _cpf, double _valor, int _code, String _est , double _vlfat): base(_cpf,_valor,_code)
        {
            estabelecimento = _est;
            vlfatSaude = _vlfat;
        }

        //FATURAR VOID
        public override void faturar()
        {
            base.faturar();
            this.valor = this.valor * 1.12;
            
        }
        public override void imprime()
        {
            Console.WriteLine(this.estabelecimento + " " + this.vlfatSaude);
        }

        //GET
        private String getEst()
        {
            return this.estabelecimento;
        }
        private double getVlfatSaude()
        {
            return this.vlfatSaude;
        }

        //SET
        private void setEst(String x)
        {
            this.estabelecimento = x;
        }
        private void setVlfatSaude(double x)
        {
            this.vlfatSaude = x;
        }
    }
}
