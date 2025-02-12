using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DDD.Model.Entities;

namespace DDD.Model.Agreggate
{
    public class Consulta
    {
        public Guid Id { get; set; }
        public Paciente? Paciente { get; set; }
        public Medico? Medico { get; set; }
        public DateTime dataConsulta { get; set; }
    }
}
