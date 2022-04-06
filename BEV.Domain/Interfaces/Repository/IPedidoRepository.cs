using BEV.Domain.Entities;
using BEV.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Domain.Interfaces.Repository;

public interface IPedidoRepository
{
    Task<List<Produto>> ListarProdutosAsync();
    Task<List<Pedido>> ListarNovosPedidosAsync();
    Task<List<Pedido>> ListarPedidosPorFiltroAsync(StatusPedido status, DateTime conclusao);
    Task<bool> InserirPedidoAsync(Pedido pedido);
    Task<bool> AlterarStatusPedidoAsync(int pedidoId);
}