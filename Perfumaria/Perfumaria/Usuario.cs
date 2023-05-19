using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfumaria
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario () 
        {
            Codigo = 0;
            Login = string.Empty;
            Nome = string.Empty;
            Senha = string.Empty;
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
                sql = "select codigo, login, senha, nome from tblUsuario \n";

                if (Codigo != 0)
                {
                    sql += "where codigo = @codigo \n";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                else if (Login != string.Empty)
                {
                    sql += "where login = @login \n";
                    param.Add(new SqlParameter("@login", Login));
                }
                else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    param.Add(new SqlParameter("@nome", '%' + Nome + '%'));
                }

                dt = acesso.ConsultarSql(sql, param);

                if (Codigo != 0 ||
                    (Login != string.Empty && dt.Rows.Count == 1))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                    Login = dt.Rows[0]["login"].ToString();
                    Nome = dt.Rows[0]["nome"].ToString();
                    Senha = dt.Rows[0]["senha"].ToString();
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
                    sql = "insert into tblUsuario \n";
                    sql += "(login, nome, senha) \n";
                    sql += "values \n";
                    sql += "(@login, @nome, @senha)";

                    
                }
                else
                {
                    sql = "update tblUsuario\n";
                    sql += "set \n";
                    sql += "login = @login, \n";
                    sql += "nome = @nome, \n";
                    sql += "senha = @senha \n";
                    sql += "where codigo = @codigo";

                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                param.Add(new SqlParameter("@login", Login));
                param.Add(new SqlParameter("@nome", Nome));
                param.Add(new SqlParameter("@senha", Senha));

                acesso.ExecutarSql(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
