using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplClsBancoDados;
using System.Data;

namespace AplClsPersistencia
{
    public class Usuarios
    {
        private BancoDados objBD = new BancoDados();
        public int pesid { get; set; }
        public string usrnome { get; set; }
        public string usrsenha { get; set; }

        private string strErro = "";

        public bool getGravarUsuario()
        {
            try
            {
                bool retorno = false;
                string strSQL = "Insert into tblusuarios (pesid, usrnome, usrsenha) values (";
                strSQL += this.pesid.ToString() + ",";
                strSQL += "'" + this.usrnome + "',";
                strSQL += "'" + this.usrsenha + "')";
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

        public bool getValidarAcesso()
        {
            try
            {
                bool retorno = false;
                string strSQL = "select * from tblusuarios where usrnome = '" + this.usrnome.ToString() + "' and usrsenha ='" + this.usrsenha.ToString() + "'";
                string[] vtEstrura = { "pesid", "usrnome", "usrsenha" };
                string[] vtDados = { "pesid", "usrnome", "usrsenha" };
                if (objBD.getConsultarDados(strSQL, vtEstrura, vtDados) != null)
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

        public DataTable getConsultarUsuario()
        {
            try
            {
                string strSQL = "select * from tblusuarios";
                string[] vtEstrura = { "pesid", "usrnome", "usrsenha" };
                string[] vtDados = { "pesid", "usrnome", "usrsenha" };
                return objBD.getConsultarDados(strSQL, vtEstrura, vtDados);
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarUsuario(int idpessoa)
        {
            try
            {
                string strSQL = "select * from tblusuarios where pesid = " + idpessoa.ToString();
                string[] vtEstrura = { "pesid", "usrnome", "usrsenha" };
                string[] vtDados = { "pesid", "usrnome", "usrsenha" };
                return objBD.getConsultarDados(strSQL, vtEstrura, vtDados);
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
        }

        public DataTable getConsultarUsuario(string nomeusuario)
        {
            try
            {
                string strSQL = "select * from tblusuarios where usrnome = '" + nomeusuario.ToString() + "'";
                string[] vtEstrura = { "pesid", "usrnome", "usrsenha" };
                string[] vtDados = { "pesid", "usrnome", "usrsenha" };
                return objBD.getConsultarDados(strSQL, vtEstrura, vtDados);
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
