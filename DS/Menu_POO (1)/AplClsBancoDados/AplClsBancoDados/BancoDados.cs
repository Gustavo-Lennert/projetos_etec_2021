using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml;
using System.Security.AccessControl;

namespace AplClsBancoDados
{
    public class BancoDados
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        private string strErro = "";

        private bool getConectar()
        {
            try
            {
                this.objCnx.ConnectionString = "Server=localhost;Database=bdagenda;User=root;Pwd=master";
                this.objCnx.Open();
                return true;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return false;
            }
        }

        private bool getDesconectar()
        {
            try
            {
                if(this.objCnx.State == ConnectionState.Open)
                {
                    this.objCnx.Close();
                }
                return true;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return false;
            }
        }

        public int getExecutarSQL(string SQL)
        {
            try
            {
                int retorno = -1;
                if(this.getConectar())
                {
                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }
                    this.objCmd.Connection = this.objCnx;
                    this.objCmd.CommandText = SQL;
                    retorno = this.objCmd.ExecuteNonQuery();
                }
                return retorno;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return -1;
            }
            finally
            {
                this.getDesconectar();
            }
        }

        public DataTable getConsultarDados(string SQL, string[] vtEstruturaTabela, string[] vtDadosTabela)
        {
            try
            {
                DataTable dtTabela = new DataTable();
                if (this.getConectar())
                {
                    //Criar as colunas da tabela virtual
                    for(int coluna=0;coluna < vtEstruturaTabela.Length; coluna++)
                    {
                        dtTabela.Columns.Add(vtEstruturaTabela[coluna].ToString());
                    }

                    if(objDados != null)
                    {
                        if(!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = SQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while(objDados.Read())
                        {
                            //Criar um espaço na tabela virtual para inserir a nova linha
                            drRegistro = dtTabela.NewRow();
                            //Criar as colunas da linha da tabela virtual e carrega a informação corresponde da tabela
                            for (int coluna = 0; coluna < vtDadosTabela.Length; coluna++)
                            {
                                drRegistro[vtEstruturaTabela[coluna].ToString()] = objDados[vtDadosTabela[coluna].ToString()].ToString();
                            }
                            dtTabela.Rows.Add(drRegistro);
                        }

                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                    else
                    {
                        dtTabela = null;
                    }
                }

                return dtTabela;
            }
            catch (Exception erro)
            {
                this.strErro = erro.Message;
                return null;
            }
            finally
            {
                this.getDesconectar();
            }
        }

        public string getErro()
        {
            return this.strErro;
        }
    }
}
