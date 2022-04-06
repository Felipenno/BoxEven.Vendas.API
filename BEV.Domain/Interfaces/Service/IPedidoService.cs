using BEV.Domain.Entities;
using BEV.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Domain.Interfaces.Service
{
    public interface IPedidoService
    {
        Task<List<Pedido>> ListarNovosPedidosAsync();
        Task<List<Pedido>> ListarPedidosPorFiltroAsync(StatusPedido status, DateTime conclusao);
        Task GerarPedidosAsync();
        Task<bool> AlterarStatusPedidoAsync(int pedidoId);
    }
}
