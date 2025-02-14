using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.ValueObject
{
    public class Cpf
    {
        public string Numero { get; set; }

        public Cpf()
        {
            Numero = ValidNumero();
        }

        private int ValidNumero()
        {
            // Implementar validação de CPF
            
            return Numero;
        }
    }
}
