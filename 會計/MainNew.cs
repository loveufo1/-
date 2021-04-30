using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 會計
{
    public partial class MainNew : Form
    {
        public MainNew()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            XElement xe = XElement.Load("MainData.xml");
            xe.Add(new XElement(
"Sell"
 , new XElement("Id", DateTime.Now.ToString())
 , new XElement("ID", txtID.Text)
 , new XElement("Name", txtName.Text)
 , new XElement("Price", txtPri.Text)
 , new XElement("Per", txtPer.Text)
 , new XElement("Client", txtClie.Text)
 , new XElement("Num", txtNum.Text)
 , new XElement("InsideDate", txtDate.Text)
  , new XElement("OutDate", "")
));
            xe.Save("MainData.xml");
            MessageBox.Show("新增成功");

            XElement xe1 = XElement.Load("ShouldPay.xml");
            xe1.Add(new XElement(
            "ShouldPay"
             , new XElement("Id", DateTime.Now.ToString())
             , new XElement("ID", txtID.Text)
             , new XElement("Name", txtName.Text)
             , new XElement("Price", txtPri.Text)
             , new XElement("Per", txtPer.Text)
             , new XElement("Client", txtClie.Text)
             , new XElement("Num", txtNum.Text)
             , new XElement("InsideDate", txtDate.Text)
             , new XElement("IsPaid", false)
             , new XElement("PaidDate", "")
            ));
            xe1.Save("ShouldPay.xml");
           

        }

        private void MainNew_Load(object sender, EventArgs e)
        {
           
        }
    }
}
