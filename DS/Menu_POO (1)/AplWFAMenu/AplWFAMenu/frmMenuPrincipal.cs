using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AplWFAMenu
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void mnuAplicativosCalculadora_Click(object sender, EventArgs e)
        {
            Process objApli = new Process();
            objApli.StartInfo.FileName = "Calc.exe";
            objApli.Start();
        }

        private void tspWord_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuAplicativosWord_Click(object sender, EventArgs e)
        {
            Process objApli = new Process();
            objApli.StartInfo.FileName = "WinWord.exe";
            objApli.Start();
        }

        private void mnuSairSistemaSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tspbtnWord_Click(object sender, EventArgs e)
        {
            mnuAplicativosWord_Click(sender, e);
        }

        private void mnuAplicativosExcel_Click(object sender, EventArgs e)
        {
            Process objApli = new Process();
            objApli.StartInfo.FileName = "Excel.exe";
            objApli.Start();
        }

        private void tspbtnExcel_Click(object sender, EventArgs e)
        {
            mnuAplicativosExcel_Click(sender, e);
        }

        private void tspbtnCalculadora_Click(object sender, EventArgs e)
        {
            mnuAplicativosCalculadora_Click(sender, e);
        }

        private void tspbtnSair_Click(object sender, EventArgs e)
        {
            mnuSairSistemaSair_Click(sender, e);
        }

        private void mnuCadastrosPessoas_Click(object sender, EventArgs e)
        {
            frmCadastroPessoas objTela = new frmCadastroPessoas();
            objTela.ShowDialog();
        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuitemCadastros_Click(object sender, EventArgs e)
        {

        }
    }
}
