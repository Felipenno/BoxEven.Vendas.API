using BEV.Domain.Enum;
using Microsoft.AspNetCore.Mvc;

namespace BEV.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> ListarPedidos()
    {
        return Ok();
    }

    [HttpGet("filtro")]
    public async Task<IActionResult> ListarPedidosPorFiltroAsync(StatusPedido status, DateTime conclusao)
    {
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> lterarStatusPedidoAsync(int pedidoId)
    {
        return Ok();
    }
}