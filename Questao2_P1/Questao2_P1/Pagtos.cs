using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2_P1
{
    class Pagtos
    {
        protected long cpf;
        protected double valor;
        protected int code;

        public Pagtos()
        {
            cpf = 0;
            valor = 0;
            code = 0;
        }
        public Pagtos(long _cpf, double _valor, int _code)
        {
            cpf = _cpf;
            valor = _valor;
            code = _code;
        }

        //FATURAR
        public virtual void faturar()
        {
            /////////////////////////////////
            
        }
        public virtual void imprime()
        {

        }


        //SET
        public void setCpf(long x)
        {
            this.cpf = x;
        }
        public void setValor(double x)
        {
            this.valor = x;
        }
        public void setCode(int x)
        {
            this.code = x;
        }

        //GET
        public long getCpf()
        {
            return this.cpf;
        }
        public double getValor()
        {
            return this.valor;
        }
        public int getCode()
        {
            return this.code;
        }

    }
}
