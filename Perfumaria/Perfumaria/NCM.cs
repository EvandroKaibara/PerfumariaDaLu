using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Perfumaria
{
    public class NCM
    {
        public int Codigo { get; set; }
        public string Ncm { get; set; }
        public string Descricao { get; set; }

        public NCM() 
        {
            Codigo = 0;
            Ncm = string.Empty;
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
                sql = "select codigo, ncm, descricao \n";
                sql += "from tblNCM \n";

                if (Codigo != 0)
                {
                    sql += "where codigo = @codigo \n";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                else if (Ncm != string.Empty)
                {
                    sql += "where ncm like  @ncm \n";
                    param.Add(new SqlParameter("@ncm", Ncm + '%'));
                }
                else if (Descricao != string.Empty)
                {
                    sql += "where descricao like @descricao \n";
                    param.Add(new SqlParameter("@descricao", '%' + Descricao + '%'));
                }

                dt = acesso.ConsultarSql(sql, param);

                if (Codigo != 0 ||
                    (Ncm != string.Empty && dt.Rows.Count == 1))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                    Ncm = dt.Rows[0]["ncm"].ToString();
                    Descricao = dt.Rows[0]["descricao"].ToString();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
