using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBank
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void frmChild_Activated(object sender, EventArgs e)
        {
            this.Hide(); // Hides Form1 but it is till in Memory
        }
        private void frmChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Unhide Form1
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            FrmAccounts frmAccounts = new FrmAccounts();
            frmAccounts.Activated += new EventHandler(frmChild_Activated); // Handler when the form is activated
            frmAccounts.FormClosed += new FormClosedEventHandler(frmChild_FormClosed); // Hander when the form is closed
            frmAccounts.Show();
        }
    }
}
