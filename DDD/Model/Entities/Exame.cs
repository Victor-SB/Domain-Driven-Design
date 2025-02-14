using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Entities
{
    internal class Exame
    {
        public Guid Id { get; private set; }
        public string Exame { get; private set; }


        public string? Cid { get; private set; }

        public string Status { get; private set; }

        public string Resultado { get; private set; }
    }
}
