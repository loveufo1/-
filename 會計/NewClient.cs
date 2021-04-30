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
   
    public partial class NewClient : Form
    {
        public string ID;
        public NewClient()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement xe = XElement.Load("Client.xml");
            if (ID != null)
            {
                var Lst = (from m in xe.Elements()
                           where m.Element("Name").Value == ID
                           select m).FirstOrDefault();
                Lst.Element("Name").Value=txtName.Text;
                Lst.Element("Address").Value =txtAddress.Text;
                Lst.Element("Num").Value = txtNum.Text ;
                Lst.Element("Person").Value=txtPerson.Text ;
                Lst.Element("Phone").Value= txtPhone.Text;
                xe.Save("Client.xml");
                MessageBox.Show("編輯成功");

            }
            else
            {
                
                xe.Add(new XElement(
    "clients"
    , new XElement("Name", txtName.Text)
    , new XElement("Address", txtAddress.Text)
    , new XElement("Num", txtNum.Text)
    , new XElement("Person", txtPerson.Text)
    , new XElement("Phone", txtPhone.Text)

    ));
                xe.Save("Client.xml");
                MessageBox.Show("新增成功");
            }
           
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            XElement xe = XElement.Load("Client.xml");
            if (ID != null)
            {
                var Lst = (from m in xe.Elements()
                          where m.Element("Name").Value == ID
                          select m).FirstOrDefault();
                txtName.Text = Lst.Element("Name").Value;
                txtAddress.Text = Lst.Element("Address").Value;
                txtNum.Text = Lst.Element("Num").Value;
                txtPerson.Text = Lst.Element("Person").Value;
                txtPhone.Text = Lst.Element("Phone").Value;

            }
        }
    }
}
