using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2_P1
{
    class Alimentacao : Pagtos
    {
        private String descricao;
        private double vlfatAliment;

        private Alimentacao()
        {
            descricao = "";
            vlfatAliment = 0;
        }
        public Alimentacao(long _cpf, double _valor, int _code, String _est, double _vlfat) : base(_cpf, _valor, _code)
        {
            descricao = _est;
            vlfatAliment = _vlfat;
        }
        public override void imprime()
        {
            Console.WriteLine(this.descricao + " " +this.vlfatAliment);
        }

        //FATURAR VOID
        public override void faturar()
        {
            base.faturar();
            this.valor = this.valor * 1.05;
        }

        //GET
        private  String getDesc()
        {
            return this.descricao;
        }
        private double getVlfat()
        {
            return this.vlfatAliment;
        }

        //SET
        private void setDesc(String x)
        {
            this.descricao = x;
        }
        private void setVlfat(double x)
        {
            this.vlfatAliment = x;
        }
    }
}
