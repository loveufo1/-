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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            XElement xe = XElement.Load("Client.xml");
            var data = from m in xe.Elements()
                       select new
                       {
                           客戶名稱 = m.Element("Name").Value,
                           地址 = m.Element("Address").Value,
                           統編 = m.Element("Num").Value,
                           聯絡人 = m.Element("Person").Value,
                           電話 = m.Element("Phone").Value,
                       };
            dataGridView1.DataSource = data.ToList();
        }

        private void B_New_Click(object sender, EventArgs e)
        {
            NewClient nw = new NewClient();
            nw.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            XElement xe = XElement.Load("Client.xml");
            var data = from m in xe.Elements()
                       select new
                       {
                           客戶名稱 = m.Element("Name").Value,
                           地址 = m.Element("Address").Value,
                           統編 = m.Element("Num").Value,
                           聯絡人 = m.Element("Person").Value,
                           電話 = m.Element("Phone").Value,
                       };
            dataGridView1.DataSource = data.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewClient nw = new NewClient();
            nw.ID = strID;
            nw.Show();
        }
    }
}
