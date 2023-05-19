using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Runtime.ConstrainedExecution;

namespace Perfumaria
{
    public class Venda
    {
        public int Codigo { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoPagamento { get; set; }
        public List<Produto> itens = new List<Produto>();

        public Venda()
        {
            Codigo = 0;
            Numero = string.Empty;
            Data = DateTime.Now;
            CodigoCliente = 0;
            CodigoPagamento = 0;    
        }

        DataTable dt = new DataTable();
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> param = new List<SqlParameter>();
        string sql = string.Empty;

        public void Emitir()
        {
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {
                    param.Clear();
                    sql = "insert into tblNotaFiscal\n";
                    sql += "(numero, data, codigoCliente, codigoUsuario, codigoPagamento)\n";
                    sql += "values\n";
                    sql += "(@numero, @data, @codigoCliente, @codigoUsuario, @codigoPagamento);\n";
                    sql += "SELECT @@IDENTITY\n";

                    param.Add(new SqlParameter("@numero", Numero));
                    param.Add(new SqlParameter("@data", Data));
                    param.Add(new SqlParameter("@codigoCliente", CodigoCliente));
                    param.Add(new SqlParameter("@codigoPagamento", CodigoPagamento));
                    param.Add(new SqlParameter("@codigoUsuario", Global.codigoUsuario));

                    Codigo = Convert.ToInt32(acesso.ExecutarSql(param, sql));

                    foreach (Produto p in itens)
                    {
                        param.Clear();
                        sql = "insert into tblItem \n";
                        sql += "(quantidade, precoUnitario, codigoProduto, codigoNotaFiscal) \n";
                        sql += "values \n";
                        sql += "(@quantidade, @precoUnitario, @codigoProduto, @codigoNotaFiscal) \n";
                        param.Add(new SqlParameter("@quantidade", p.Quantidade));
                        param.Add(new SqlParameter("@precoUnitario", p.PrecoUnitario));
                        param.Add(new SqlParameter("@codigoProduto", p.Codigo));
                        param.Add(new SqlParameter("@codigoNotaFiscal", Codigo));

                        acesso.ExecutarSql(sql, param);

                        param.Clear();
                        sql = "update tblProduto \n";
                        sql += "set \n";
                        sql += "quantidade -= @quantidade \n";
                        sql += "where codigo = @codigo";

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

        public DataTable Consultar(DateTime? DataInicio, DateTime? DataTermino)
        {
            try
            {
                param.Clear();
                sql = "select nf.codigo, nf.numero, data, c.nome, u.nome, nf.codigoCliente \n";
                sql += "from tblNotaFiscal nf \n";
                sql += "inner join tblCliente c on nf.codigoCliente = c.codigo\n";
                sql += "inner join tblUsuario u on nf.codigoUsuario = u.codigo\n";
                sql += "where 1 = 1 \n";
                if (Codigo != 0)
                {
                    sql += "and nf.codigo = @codigo \n";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                else if (Numero != string.Empty)
                {
                    sql += "and nf.numero = @numero \n";
                    param.Add(new SqlParameter("@numero", Numero));
                }
                else if (CodigoCliente != 0)
                {
                    sql += "and nf.codigoCliente = @codigoCliente \n";
                    param.Add(new SqlParameter("@codigoCliente", CodigoCliente));
                }

                if(DataInicio != null)
                {
                    DataInicio = DataInicio.Value.Date;
                }
                if(DataTermino  != null)
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

                if (Codigo != 0)
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                    Numero = dt.Rows[0]["numero"].ToString();
                    Data = Convert.ToDateTime(dt.Rows[0]["data"]);
                    CodigoCliente = Convert.ToInt32(dt.Rows[0]["codigoCliente"]);

                    param.Clear();
                    sql = "select sku, descricao, i.precoUnitario, i.quantidade, i.precoUnitario*i.quantidade ValorTotal\n";
                    sql += "from tblItem i \n";
                    sql += "inner join tblProduto p on i.codigoProduto = p.codigo\n";
                    sql += "where codigoNotaFiscal = @codigoNotaFiscal";
                    param.Add(new SqlParameter("@codigoNotaFiscal", Codigo));

                    dt = acesso.ConsultarSql(sql, param);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ValidarQuantidade(int quantidade)
        {
            try
            {
                param.Clear();
                sql = "select quantidade from tblProduto\n";
                sql += "where quantidade < @quantidade";

                param.Add(new SqlParameter("@quantidade", Math.Abs(quantidade)));

                dt = acesso.ConsultarSql(sql, param);
                if (dt.Rows.Count != 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            ;
        }
    }
}
