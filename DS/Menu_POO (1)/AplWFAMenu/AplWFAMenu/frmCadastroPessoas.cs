using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplClsPersistencia;

namespace AplWFAMenu
{
    public partial class frmCadastroPessoas : Form
    {
        public Pessoas objPessoa = new Pessoas();
        public Usuarios objUsuario = new Usuarios();

        public frmCadastroPessoas()
        {
            InitializeComponent();
        }

        private void frmCadastroPessoas_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Nome Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtEMail.Text.Trim() == "")
            {
                MessageBox.Show("Campo E-Mail Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtTelefoneFixo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Fixo Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtTelefoneCelular.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Celular Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Campo Usuário Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Campo Senha Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Enviando os dados da pessoa para a classe de pessoas
                objPessoa.pesnome = txtNome.Text;
                objPessoa.pesemail = txtEMail.Text;
                objPessoa.pestelefonefixo = txtTelefoneFixo.Text;
                objPessoa.pestelefonecelular = txtTelefoneCelular.Text;
                if (objPessoa.getGravarPessoa())
                {
                    DataTable objRetorno = objPessoa.getConsultarPessoa("pesnome = '" + txtNome.Text + "' and pesemail = '" + txtEMail.Text + "'");
                    if (objRetorno != null)
                    {
                        //Recuperar o id da pessoa cadastrada
                        objUsuario.pesid = int.Parse(objRetorno.Rows[0]["pesid"].ToString());
                        //Enviando os dados do usuario para a classe de usuarios
                        objUsuario.usrnome = txtUsuario.Text;
                        objUsuario.usrsenha = txtSenha.Text;
                        if (objUsuario.getGravarUsuario())
                        {
                            MessageBox.Show("Pessoa incluída com sucesso!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show(objUsuario.getErro(), "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show(objPessoa.getErro(), "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show(objPessoa.getErro(), "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Código Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Nome Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtEMail.Text.Trim() == "")
            {
                MessageBox.Show("Campo E-Mail Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtTelefoneFixo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Fixo Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtTelefoneCelular.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Celular Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Campo Usuário Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Campo Senha Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                objPessoa.pesid = int.Parse(txtCodigo.Text);
                objPessoa.pesnome = txtNome.Text;
                objPessoa.pesemail = txtEMail.Text;
                objPessoa.pestelefonefixo = txtTelefoneFixo.Text;
                objPessoa.pestelefonecelular = txtTelefoneCelular.Text;
                if (objPessoa.getAlterarPessoa())
                {
                    MessageBox.Show("Pessoa alterada com sucesso!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show(objPessoa.getErro(), "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Código Obrigatório!", "Cadastro de Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (MessageBox.Show("Deseja excluir a pessoa", "Cadastro de Pessoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    objPessoa.pesid = int.Parse(txtCodigo.Text);

                    if (objPessoa.getExcluirPessoa())
                    {
                        MessageBox.Show("Pessoa excluida com sucesso!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show(objPessoa.getErro(), "Cadastro de Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEMail.Text = "";
            txtTelefoneFixo.Text = "";
            txtTelefoneCelular.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";

            txtNome.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Código Obrigatório!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DataTable dtDados = objPessoa.getConsultarPessoa(int.Parse(txtCodigo.Text));
                if (dtDados != null)
                {
                    txtNome.Text = dtDados.Rows[0]["pesnome"].ToString();
                    txtEMail.Text = dtDados.Rows[0]["pesemail"].ToString();
                    txtTelefoneFixo.Text = dtDados.Rows[0]["pestelefonefixo"].ToString();
                    txtTelefoneCelular.Text = dtDados.Rows[0]["pestelefonecelular"].ToString();

                    //Consultat os dados do usuario
                    dtDados = objUsuario.getConsultarUsuario(int.Parse(txtCodigo.Text));
                    if (dtDados != null)
                    {
                        txtUsuario.Text = dtDados.Rows[0]["usrnome"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show(objPessoa.getErro(), "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
