using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Drawing;

namespace Perfumaria
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Sku { get; set; }
        public string Setor { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool Importado { get; set; }
        public int Quantidade { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoNCM { get; set; }
        public int CodigoSetor { get; set; }
        public byte[] Imagem { get; set; }
        public List<Produto> produtos = new List<Produto>();

        public Produto()
        {
            Codigo = 0;
            Sku = string.Empty;
            Descricao = string.Empty;
            PrecoUnitario = 0;
            Importado = false;
            Quantidade = 0;
            CodigoUsuario = 0;
            CodigoNCM = 0;
            CodigoSetor = 0;
        }

        DataTable dt = new DataTable();
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> param = new List<SqlParameter>();
        string sql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                param.Clear();

                sql = "select p.codigo, p.sku, p.descricao, p.precoUnitario, p.importado, p.quantidade, p.imagem, p.codigoUsuario, p.codigoNCM, isnull(codigoSetor,0) codigoSetor, s.descricao \n";
                sql += "from tblProduto p \n";
                sql += "left Join tblSetor s on p.codigoSetor = s.codigo \n";

                if (Codigo != 0)
                {
                    sql += "where p.codigo = @codigo \n";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                else if (Sku != string.Empty)
                {
                    sql += "where p.sku like @sku \n";
                    param.Add(new SqlParameter("@sku", Sku + '%'));
                }
                else if (Descricao != string.Empty)
                {
                    sql += "where p.descricao like @descricao \n";
                    param.Add(new SqlParameter("@descricao", '%' + Descricao + '%'));
                }

                dt = acesso.ConsultarSql(sql, param);

                if (Codigo != 0 || (Sku != string.Empty && dt.Rows.Count == 1))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                    Sku = dt.Rows[0]["sku"].ToString();
                    Descricao = dt.Rows[0]["descricao"].ToString();
                    PrecoUnitario = Convert.ToDecimal(dt.Rows[0]["precoUnitario"]);
                    Importado = Convert.ToBoolean(dt.Rows[0]["importado"]);
                    Quantidade = Convert.ToInt32(dt.Rows[0]["quantidade"]);
                    if (dt.Rows[0]["imagem"] != DBNull.Value)
                    {
                        Imagem = (byte[])(dt.Rows[0]["imagem"]);
                    }
                    CodigoNCM = Convert.ToInt32(dt.Rows[0]["codigoNCM"]);
                    CodigoSetor = Convert.ToInt32(dt.Rows[0]["codigoSetor"]);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Gravar()
        {
            try
            {
                param.Clear();
                if (Codigo == 0)
                {
                    sql = "insert into tblProduto \n";
                    sql += "(sku, descricao, precoUnitario, importado, quantidade, imagem, codigoUsuario, codigoNCM, codigoSetor) \n";
                    sql += "values \n";
                    sql += "(@sku, @descricao, @precoUnitario, @importado, @quantidade, @imagem, @codigoUsuario, @codigoNCM, @codigoSetor)";
                }
                else
                {
                    sql = "update tblProduto \n";
                    sql += "set \n";
                    sql += "sku = @sku, \n";
                    sql += "descricao = @descricao, \n";
                    sql += "precoUnitario = @precoUnitario, \n";
                    sql += "importado = @importado, \n";
                    sql += "quantidade = @quantidade, \n";
                    sql += "imagem = @imagem, \n";
                    sql += "codigoUsuario = @codigoUsuario, \n";
                    sql += "codigoNCM = @codigoNCM, \n";
                    sql += "codigoSetor = @codigoSetor \n";
                    sql += "where codigo = @codigo";

                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                param.Add(new SqlParameter("@sku", Sku));
                param.Add(new SqlParameter("@descricao", Descricao));
                param.Add(new SqlParameter("@precoUnitario", PrecoUnitario));
                param.Add(new SqlParameter("@importado", Importado));
                param.Add(new SqlParameter("@quantidade", Quantidade));
                if(Imagem != null)
                {
                    param.Add(new SqlParameter("@imagem", Imagem));
                }
                else
                {
                    param.Add(new SqlParameter("@imagem", DBNull.Value));
                }
                param.Add(new SqlParameter("@codigoUsuario", Global.codigoUsuario));
                param.Add(new SqlParameter("@codigoNCM", CodigoNCM));
                if (CodigoSetor == 0)
                {
                    param.Add(new SqlParameter("@codigoSetor", DBNull.Value));
                }
                else
                {
                    param.Add(new SqlParameter("@codigoSetor", CodigoSetor));
                }


                acesso.ExecutarSql(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ValidarValorSetor(decimal valor, int codigoSetor)
        {
            try 
            {
                if (valor < 0)
                {
                    param.Clear();
                    sql = "select precoUnitario from tblProduto\n";
                    sql += "where precoUnitario < @valor and codigoSetor = @codigoSetor";

                    param.Add(new SqlParameter("@codigoSetor", codigoSetor));
                    param.Add(new SqlParameter("@valor", Math.Abs(valor)));

                    dt = acesso.ConsultarSql(sql, param);
                    if (dt.Rows.Count != 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AlterarPrecoSetor(decimal valor, bool porcentagem)
        {
            try
            {

                if (porcentagem)
                {
                    param.Clear();
                    sql = "update tblProduto \n";
                    sql += "set \n";
                    sql += "precoUnitario = precoUnitario*(1+@valor/100) \n";
                    sql += "where codigoSetor = @codigoSetor";

                    param.Add(new SqlParameter("@codigoSetor", CodigoSetor));
                    param.Add(new SqlParameter("@valor", valor));

                    acesso.ExecutarSql(sql, param);
                }
                else
                {                    
                    param.Clear();
                    sql = "update tblProduto \n";
                    sql += "set \n";
                    sql += "precoUnitario += @valor \n";
                    sql += "where codigoSetor = @codigoSetor";

                    param.Add(new SqlParameter("@codigoSetor", CodigoSetor));
                    param.Add(new SqlParameter("@valor", valor));

                    acesso.ExecutarSql(sql, param);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
