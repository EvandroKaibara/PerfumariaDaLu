using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Perfumaria
{
    public static class Global
    {
        public static int codigoUsuario;
        public static string usuario;
        public static string nome;
        public static string conexao;
        public static string servidor;
        public static string banco;

        public static void MontarStringConexao()
        {
            servidor = ConfigurationManager.AppSettings["servidor"].ToString();
            banco = ConfigurationManager.AppSettings["banco"].ToString();

            conexao = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;", servidor, banco);
        }

        public static DataTable ConsultarEstados()
        {
            try
            {
                string sql = "select codigo, uf from tblUF";
                DataTable dt = new DataTable();
                AcessoBD acesso = new AcessoBD();
                dt = acesso.ConsultarSql(sql, new List<SqlParameter>());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarMetodoPagamento()
        {
            try
            {
                string sql = "select codigo, metodo from tblPagamento";
                DataTable dt = new DataTable();
                AcessoBD acesso = new AcessoBD();
                dt = acesso.ConsultarSql(sql, new List<SqlParameter>());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarNCM()
        {
            try
            {
                string sql = "select codigo, ncm from tblNCM";
                DataTable dt = new DataTable();
                AcessoBD acesso = new AcessoBD();
                dt = acesso.ConsultarSql(sql, new List<SqlParameter>());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarCidades(int CodigoUF)
        {
            try
            {
                string sql = "select codigo, cidade from tblCidade \n";
                sql += "where codigoUF = @codigoUF";

                DataTable dt = new DataTable();
                AcessoBD acesso = new AcessoBD();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@codigoUF", CodigoUF));
                dt = acesso.ConsultarSql(sql, param);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ConsultarEstados(int CodigoCidade)
        {
            try
            {
                string sql = "select codigoUF from tblCidade \n";
                sql += "where codigo = @codigo";

                AcessoBD acesso = new AcessoBD();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@codigo", CodigoCidade));
                string retorno = acesso.ExecutarSql(param, sql);
                return Convert.ToInt32(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarSetores()
        {
            try
            {
                string sql = "select codigo, descricao from tblSetor";
                DataTable dt = new DataTable();
                AcessoBD acesso = new AcessoBD();
                dt = acesso.ConsultarSql(sql, new List<SqlParameter>());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarNCM(int CodigoNCM)
        {
            try
            {
                string sql = "select codigo, ncm, descricao from tblNCM \n";
                sql += "where codigo = @codigo";

                DataTable dt = new DataTable();
                AcessoBD acesso = new AcessoBD();
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@codigo", CodigoNCM));
                dt = acesso.ConsultarSql(sql, param);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool IsValid(string cpf)
        {
            return IsCpf(cpf); 
        }

        private static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
        public static Image BytesToImage(byte[] bytes)
        {
            try
            {
                MemoryStream oMemoryStream = new MemoryStream(bytes);
                return Image.FromStream(oMemoryStream);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static byte[] ImageToBytes(PictureBox picture)
        {
            try
            {
                byte[] bytes;
                MemoryStream oMemoryStream = new MemoryStream();
                picture.Image.Save(oMemoryStream, ImageFormat.Jpeg);
                bytes = new byte[oMemoryStream.Length];
                oMemoryStream.Position = 0;
                oMemoryStream.Read(bytes, 0, bytes.Length);
                return bytes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
