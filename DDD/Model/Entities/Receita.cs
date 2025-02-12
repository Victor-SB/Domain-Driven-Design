using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Entities
{
    public class Receita
    {
        public int CID { get; set; }
        public Paciente? paciente { get; set; }
    }
}
