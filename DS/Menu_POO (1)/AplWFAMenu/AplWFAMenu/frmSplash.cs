using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAMenu
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value >= 100)
            {
                tmrSplash.Enabled=false;
                Hide();
                frmLogin objTela = new frmLogin();
                objTela.ShowDialog();
            }
            else
            {
                pgbSplash.Value += 10;
            }
        }
    }
}
