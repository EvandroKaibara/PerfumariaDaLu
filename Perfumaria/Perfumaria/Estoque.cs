using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Perfumaria
{
    public class Estoque
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public List<Produto> produtos = new List<Produto>();

        public Estoque()
        {
            Codigo = 0;
            Data = DateTime.Now;
        }

        DataTable dt = new DataTable();
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> param = new List<SqlParameter>();
        string sql = string.Empty;

        public void EfetivarEntrada()
        {
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {
                    foreach (Produto p in produtos)
                    {
                        param.Clear();
                        sql = "insert into tblEntradaEstoque \n";
                        sql += "(data, quantidade, codigoProduto, codigoUsuario) \n";
                        sql += "values \n";
                        sql += "(@data, @quantidade, @codigoProduto, @codigoUsuario)";

                        param.Add(new SqlParameter("@data", Data));
                        param.Add(new SqlParameter("@quantidade", p.Quantidade));
                        param.Add(new SqlParameter("@codigoProduto", p.Codigo));
                        param.Add(new SqlParameter("@codigoUsuario", Global.codigoUsuario));

                        acesso.ExecutarSql(sql, param);

                        sql = "update tblProduto \n";
                        sql += "set quantidade += @quantidade \n";
                        sql += "where codigo = @codigo \n";

                        param.Clear();
                        param.Add(new SqlParameter("@quantidade", p.Quantidade));
                        param.Add(new SqlParameter("@codigo", p.Codigo));

                        acesso.ExecutarSql(sql, param);
                    }
                    transacao.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarEntradas(int CodigoProduto, string NumeroNotaFiscal, DateTime? DataInicio, DateTime? DataTermino)
        {
            try
            {
                param.Clear();
                sql = "select ee.codigo, ee.data, \n";
                sql += "p.sku, p.descricao, ee.quantidade, \n";
                sql += "u.login, u.nome \n";
                sql += "from tblEntradaEstoque ee \n";
                sql += "inner join tblProduto p on ee.codigoProduto = p.codigo \n";
                sql += "inner join tblUsuario u on ee.codigoUsuario = u.codigo \n";
                sql += "where \n";
                sql += "1=1 \n";
                if (CodigoProduto != 0)
                {
                    sql += "and codigoProduto = @codigoProduto \n";
                    param.Add(new SqlParameter("@codigoProduto", CodigoProduto));
                }
                if (DataInicio != null && DataTermino == null)
                {
                    sql += "and data >= @dataInicio \n";
                    param.Add(new SqlParameter("dataInicio", DataInicio));
                }
                else if (DataTermino != null && DataInicio == null)
                {   
                    sql += "and data <= @dataTermino \n";
                    param.Add(new SqlParameter("dataTermino", DataTermino));
                }
                else if (DataInicio != null && DataTermino != null)
                {
                    sql += "and data between @dataInicio and @dataTermino \n";
                    param.Add(new SqlParameter("@dataInicio", DataInicio));
                    param.Add(new SqlParameter("@dataTermino", DataTermino));
                }
                dt = acesso.ConsultarSql(sql, param);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarEntradas(int CodigoProduto,DateTime? DataInicio,
            DateTime? DataTermino)
        {
            try
            {
                param.Clear();
                sql = "select ee.codigo, ee.data, \n";
                sql += "p.sku, p.descricao, ee.quantidade, \n";
                sql += "u.login, u.nome \n";
                sql += "from tblEntradaEstoque ee \n";
                sql += "inner join tblProduto p on ee.codigoProduto = p.codigo \n";
                sql += "inner join tblUsuario u on ee.codigoUsuario = u.codigo \n";
                sql += "where \n";
                sql += "1=1 \n";
                if (CodigoProduto != 0)
                {
                    sql += "and codigoProduto = @codigoProduto \n";
                    param.Add(new SqlParameter("@codigoProduto", CodigoProduto));
                }

                if (DataInicio != null)
                {
                    DataInicio = DataInicio.Value.Date;
                }
                if (DataTermino != null)
                {
                    DataTermino = DataTermino.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(59);
                }

                if (DataInicio != null && DataTermino == null)
                {
                    sql += "and data >= @dataInicio \n";
                    param.Add(new SqlParameter("dataInicio", DataInicio));
                }
                else if (DataTermino != null && DataInicio == null)
                {
                    sql += "and data <= @dataTermino \n";
                    param.Add(new SqlParameter("dataTermino", DataTermino));
                }
                else if (DataInicio != null && DataTermino != null)
                {
                    sql += "and data between @dataInicio and @dataTermino \n";
                    param.Add(new SqlParameter("@dataInicio", DataInicio));
                    param.Add(new SqlParameter("@dataTermino", DataTermino));
                }

                dt = acesso.ConsultarSql(sql, param);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
