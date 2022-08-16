using Clinica.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Consulta
    {

        
        
            public Paciente paciente { get; set; }
            public Medico medico { get; set; }
            public DateTime dataHora { get; set; }

        public override string ToString()
        {
            return
                this.paciente + "\n" +
                this.medico + "\n" +
                this.dataHora + "\n" 
                
                ;
        }

    }
}
