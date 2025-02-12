using DDD.Model.Agreggate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Repositories
{
    public interface IConsultaRepository
    {
        Consulta ObterPorId(Guid id);
        void Salvar(Consulta consulta);
    }
}
