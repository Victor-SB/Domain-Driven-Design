using DDD.Model.Agreggate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Model.Repositories
{
    public interface IPedidoDeExamesRepository
    {
        PedidoDeExames ObterPorId(Guid id);
        void Salvar(PedidoDeExames pedidoDeExames);
    }
}
