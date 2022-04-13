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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuarios objUsuario = new Usuarios();

            objUsuario.usrnome = txtUsuario.Text.Trim();
            objUsuario.usrsenha = txtSenha.Text.Trim();
            if (objUsuario.getValidarAcesso())
            {
                Hide();
                frmMenuPrincipal objTela = new frmMenuPrincipal();
                objTela.ShowDialog();
            }
            else
            {
                lblMensagemErro.Text = "Usuário e/ou Senha inválido(s) !!!";
                txtUsuario.Focus();
            }
        }
    }
}
