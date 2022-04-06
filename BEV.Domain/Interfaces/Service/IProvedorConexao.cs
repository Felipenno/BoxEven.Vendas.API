using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEV.Domain.Interfaces.Service;

public interface IProvedorConexao
{
    public SqlConnection BoxEvenConexao();
    public string BoxEvenMongoConexao();
    public string StringConexao();
}