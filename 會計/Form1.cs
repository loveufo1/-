using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 會計
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_InandOut_Click(object sender, EventArgs e)
        {
            InAndOut ina = new InAndOut();
            ina.Show();
        }

        private void B_Out_Click(object sender, EventArgs e)
        {
            ShouldPay sh = new ShouldPay();
            sh.ShowDialog();
        }

        private void B_Client_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.ShowDialog();
        }
    }
}
