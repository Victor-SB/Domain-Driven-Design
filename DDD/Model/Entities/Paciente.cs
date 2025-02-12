using DDD.Model.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Entities
{
    public class Paciente
    {
        public Guid Id { get; private set; }
        public int Nome { get; set; }
        public required Cpf Cpf { get; set; }
        public Endereco? Endereco { get; set; }
    }
}
