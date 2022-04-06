using BEV.Domain.Entities;
using BEV.Domain.Enum;
using BEV.Domain.Interfaces.Repository;
using BEV.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Service;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _pedidoRepository;

    public PedidoService(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    public Task<bool> AlterarStatusPedidoAsync(int pedidoId)
    {
        throw new NotImplementedException();
    }

    public Task GerarPedidosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Pedido>> ListarNovosPedidosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Pedido>> ListarPedidosPorFiltroAsync(StatusPedido status, DateTime conclusao)
    {
        throw new NotImplementedException();
    }
}
