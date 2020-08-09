using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class graduacao : funcionario
    {
        private string universidade;
        private string curso;

        public graduacao(String _nome, String _codigo, String _universidade, String _curso) : base(_nome, _codigo)
        {
            universidade = _universidade;
            curso = _curso;
        }


        public override double salario()
        {
            base.salario();
            double totalSalario;
            totalSalario = inicial * 2;
            return totalSalario;
        }
    }
}
