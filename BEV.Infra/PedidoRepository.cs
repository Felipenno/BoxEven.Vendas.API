using BEV.Domain.Entities;
using BEV.Domain.Enum;
using BEV.Domain.Interfaces.Repository;
using BEV.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Infra.SqlServer;

public class PedidoRepository : IPedidoRepository
{
    private readonly IProvedorConexao _provedorConexao;

    public PedidoRepository(IProvedorConexao provedorConexao)
    {
        _provedorConexao = provedorConexao;
    }

    public Task<bool> AlterarStatusPedidoAsync(int pedidoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> InserirPedidoAsync(Pedido pedido)
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

    public Task<List<Produto>> ListarProdutosAsync()
    {
        throw new NotImplementedException();
    }
}