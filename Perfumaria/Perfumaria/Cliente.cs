using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing;

namespace Perfumaria
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public int CodigoCidade { get; set; }
        public int CodigoUsuario { get; set; }

        public Cliente()
        {
            Codigo = 0;
            Nome = string.Empty;
            Endereco = string.Empty;
            Numero = string.Empty;
            Complemento = string.Empty;
            Cep = string.Empty;
            Bairro = string.Empty;
            Cpf = string.Empty;
            Telefone = string.Empty;
            CodigoCidade = 0;
            CodigoUsuario = 0;
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
                sql = "select codigo, nome, endereco, numero, complemento, cep, bairro, telefone, cpf, codigoCidade, codigoUsuario \n";
                sql += "from tblCliente \n";

                if (Codigo != 0)
                {
                    sql += "where codigo = @codigo \n";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                else if (Cpf != string.Empty)
                {
                    sql += "where cpf like @cpf \n";
                    param.Add(new SqlParameter("@cpf", Cpf + '%'));
                }
                else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    param.Add(new SqlParameter("@nome", '%' + Nome + '%'));
                }

                dt = acesso.ConsultarSql(sql, param);

                if (Codigo != 0 || (Cpf != string.Empty && dt.Rows.Count == 1))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                    Nome = dt.Rows[0]["nome"].ToString();
                    Endereco = dt.Rows[0]["endereco"].ToString();
                    Numero = dt.Rows[0]["numero"].ToString();
                    Complemento = dt.Rows[0]["complemento"].ToString();
                    Cep = dt.Rows[0]["cep"].ToString();
                    Bairro = dt.Rows[0]["bairro"].ToString();
                    Cpf = dt.Rows[0]["cpf"].ToString();
                    Telefone = dt.Rows[0]["telefone"].ToString();
                    CodigoCidade = Convert.ToInt32(dt.Rows[0]["codigoCidade"]);
                    CodigoUsuario = Convert.ToInt32(dt.Rows[0]["codigoUsuario"]);
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
                    sql = "insert into tblCliente \n";
                    sql += "(nome, endereco, numero, complemento, cep, bairro, cpf, telefone, codigoCidade, codigoUsuario) \n";
                    sql += "values \n";
                    sql += "(@nome, @endereco, @numero, @complemento, @cep, @bairro, @cpf, @telefone, @codigoCidade, @codigoUsuario)";
                }
                else
                {
                    sql = "update tblCliente \n";
                    sql += "set \n";
                    sql += "nome = @nome,";
                    sql += "endereco = @endereco,";
                    sql += "numero = @numero,";
                    sql += "complemento = @complemento,";
                    sql += "cep = @cep,";
                    sql += "bairro = @bairro,";
                    sql += "cpf = @cpf,";
                    sql += "telefone = @telefone,";
                    sql += "codigoCidade = @codigoCidade,";
                    sql += "codigoUsuario = @codigoUsuario \n";
                    sql += "where codigo = @codigo";
                    param.Add(new SqlParameter("@codigo", Codigo));
                }
                param.Add(new SqlParameter("@nome", Nome));
                param.Add(new SqlParameter("@endereco", Endereco));
                param.Add(new SqlParameter("@numero", Numero));
                param.Add(new SqlParameter("@complemento", Complemento));
                param.Add(new SqlParameter("@cep", Cep));
                param.Add(new SqlParameter("@bairro", Bairro));
                param.Add(new SqlParameter("@cpf", Cpf));
                param.Add(new SqlParameter("@telefone", Telefone));
                param.Add(new SqlParameter("@codigoCidade", CodigoCidade));
                param.Add(new SqlParameter("@codigoUsuario", Global.codigoUsuario));

                acesso.ExecutarSql(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
