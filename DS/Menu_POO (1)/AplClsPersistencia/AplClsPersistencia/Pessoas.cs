using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using AplClsBancoDados;

namespace AplClsPersistencia
{
    public class Pessoas
    {
        private BancoDados objBD = new BancoDados();
        public int pesid { get; set; }
        public string pesnome { get; set; }
        public string pesemail { get; set; }
        public string pestelefonefixo { get; set; }
        public string pestelefonecelular { get; set; }

        private string strErro = "";

        public bool getGravarPessoa()
        {
            try
            {
                bool retorno = false;
                string strSQL = "Insert into tblpessoas (pesid, pesnome, pesemail, pestelefonefixo, pestelefonecelular) values (NULL,";
                strSQL += "'" + this.pesnome + "',";
                strSQL += "'" + this.pesemail + "',";
                strSQL += "'" + this.pestelefonefixo + "',";
                strSQL += "'" + this.pestelefonecelular + "')";
                if(this.objBD.getExecutarSQL(strSQL) > 0)
                {
                    retorno = true;
                }
                return retorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return false;
            }
        }

        public bool getAlterarPessoa()
        {
            try
            {
                bool retorno = false;
                string strSQL = "update tblpessoas set ";
                strSQL += "pesnome='" + this.pesnome + "',";
                strSQL += "pesemail='" + this.pesemail + "',";
                strSQL += "pestelefonefixo='" + this.pestelefonefixo + "',";
                strSQL += "pestelefonecelular='" + this.pestelefonecelular + "' ";
                strSQL += "where pesid =" + this.pesid.ToString();
                if (this.objBD.getExecutarSQL(strSQL) >= 0)
                {
                    retorno = true;
                }
                return retorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return false;
            }
        }

        public bool getExcluirPessoa()
        {
            try
            {
                bool retorno = false;
                string strSQL = "delete from tblpessoas where pesid =" + this.pesid.ToString();
                if (this.objBD.getExecutarSQL(strSQL) > 0)
                {
                    retorno = true;
                }
                return retorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return false;
            }
        }

        public DataTable getConsultarPessoa()
        {
            try
            {
                string strSQL = "select * from tblpessoas order by pesnome";
                string[] vtEstrura = { "pesid", "pesnome", "pesemail", "pestelefonefixo", "pestelefonecelular" };
                string[] vtDados = { "pesid", "pesnome", "pesemail", "pestelefonefixo", "pestelefonecelular" };
                return objBD.getConsultarDados(strSQL, vtEstrura, vtDados);
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPessoa(int idpessoa)
        {
            try
            {
                string strSQL = "select * from tblpessoas where pesid = " + idpessoa.ToString();
                string[] vtEstrura = { "pesid", "pesnome", "pesemail", "pestelefonefixo", "pestelefonecelular" };
                string[] vtDados = { "pesid", "pesnome", "pesemail", "pestelefonefixo", "pestelefonecelular" };
                return objBD.getConsultarDados(strSQL, vtEstrura, vtDados);
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarPessoa(string condicao)
        {
            try
            {
                string strSQL = "select * from tblpessoas where " + condicao + " order by pesnome";
                string[] vtEstrutura = { "pesid", "pesnome", "pesemail", "pestelefonefixo", "pestelefonecelular" };
                string[] vtDados = { "pesid", "pesnome", "pesemail", "pestelefonefixo", "pestelefonecelular" };
                return objBD.getConsultarDados(strSQL, vtEstrutura, vtDados);
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public string getErro()
        {
            return this.strErro;
        }
    }
}
