using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Model
{
    internal class Dependente
    {
        public int codd { get; set; }

        public string nome { get; set; }

        public string nascimento { get; set; }

        public Funcionario funcionario { get; set; }
    }
}
