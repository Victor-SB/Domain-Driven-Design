using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Entities
{
    internal class PedidoDeExames
    {
        public Guid Id { get; private set; }
        public Paciente? Paciente { get; private set; }

        public Medico? Medico { get; private set; }

       public Exame[] Exames { get; private set; }

       public DateTime DataDoPedido { get; private set; }
    }
}
