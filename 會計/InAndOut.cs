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
    public partial class InAndOut : Form
    {
        public InAndOut()
        {
            InitializeComponent();
        }

        private void InAndOut_Load(object sender, EventArgs e)
        {
            XElement xe = XElement.Load("MainData.xml");
            var data = from m in xe.Elements()
                       orderby m.Element("Id").Value
                       select new
                       {
                           代號 = m.Element("ID").Value,
                           名稱 = m.Element("Name").Value,
                           單位 = m.Element("Per").Value,
                           存量 = m.Element("Num").Value,
                           單價 = m.Element("Price").Value,
                           客戶 = m.Element("Client").Value,
                           出貨日期 = m.Element("OutDate").Value,
                           進貨日期 = m.Element("InsideDate").Value,
                       };
            dataGridView1.DataSource = data.ToList();
        }

        private void B_New_Click(object sender, EventArgs e)
        {
            MainNew nw = new MainNew();
            nw.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
