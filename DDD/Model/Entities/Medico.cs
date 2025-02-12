using DDD.Model.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Entities
{
    public class Medico
    {
        public Guid Id { get; private set; }
        public int Nome { get; set; }
        public int Crm { get; private set; }
        public Endereco? Endereco { get; set; }

        public Medico()
        {
            Id = Guid.NewGuid();
            Crm = ValidCrm();
        }

        private int ValidCrm()
        {
            if (Crm.ToString().Length < 6)
            {
                throw new Exception("O CRM deve ter pelo menos 6 caracteres.");
            }

            // Caso o CRM seja válido, retorne o valor ou continue com a lógica
            return Crm;
        }




    }
    }
}
