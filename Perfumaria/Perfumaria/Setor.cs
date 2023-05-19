using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfumaria
{
    public class Setor
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public Setor()
        {
            Codigo = 0;
            Descricao = string.Empty;
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
                sql = "select codigo, descricao from tblSetor \n";

                if (Codigo != 0)
                {
                    sql += "where codigo = @codigo \n";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                else if (Descricao != string.Empty)
                {
                    sql += "where descricao like @descricao \n";
                    param.Add(new SqlParameter("@descricao", '%' + Descricao + '%'));
                }

                dt = acesso.ConsultarSql(sql, param);

                if (Codigo != 0 || (Descricao != string.Empty && dt.Rows.Count == 1))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                    Descricao = dt.Rows[0]["descricao"].ToString();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ExecutarSQL()
        {
            try
            {
                param.Clear();
                if (Codigo == 0)
                {
                    sql = "insert into tblSetor \n";
                    sql += "(descricao) \n";
                    sql += "values \n";
                    sql += "(@descricao)";
                }
                else
                {
                    sql = "update tblSetor\n";
                    sql += "set \n";
                    sql += "descricao = @descricao \n";
                    sql += "where codigo = @codigo";

                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                param.Add(new SqlParameter("@descricao", Descricao));

                acesso.ExecutarSql(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
