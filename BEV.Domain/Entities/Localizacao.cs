using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Domain.Entities;

public class Localizacao
{
    public int LocalizacaoId { get; private set; }
    public string Andar { get; private set; }
    public int Corredor { get; private set; }
    public char Lado { get; private set; }
    public int Prateleira { get; private set; }
    public int Vao { get; private set; }
    public int? ProdutoId { get; private set; }
    public Produto? Produto { get; private set; }
}
