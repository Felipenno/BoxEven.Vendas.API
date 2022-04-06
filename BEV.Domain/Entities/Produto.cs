using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Domain.Entities;

public class Produto
{
    public int ProdutoId { get; private set; }
    public bool? Ativo { get; private set; }
    public int? Quantidade { get; private set; }
    public decimal? Preco { get; private set; }
    public string? Nome { get; private set; }
    public string? ImagemTipo { get; private set; }
    public string? ImagemNome { get; private set; }
    public string? CodigoBarras { get; private set; }
    public DateTime? Criacao { get; private set; }
    public DateTime? Atualizacao { get; private set; }
    public int? UnidadeMedidaId { get; private set; }
    public UnidadeMedida? UnidadeMedida { get; private set; }

    public List<Localizacao>? Localizacoes { get; private set; }
}
