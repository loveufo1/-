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
    public partial class ShouldPay : Form
    {
        public ShouldPay()
        {
            InitializeComponent();
        }

        private void ShouldPay_Load(object sender, EventArgs e)
        {
            XElement xe = XElement.Load("ShouldPay.xml");
            var data = from m in xe.Elements()
                       orderby m.Element("Id").Value
                       select new
                       {
                           代號 = m.Element("ID").Value,
                           客戶 = m.Element("Client").Value,
                           名稱 = m.Element("Name").Value,
                           已付款=m.Element("IsPaid").Value=="false"? "未付款" : "已付款",
                           付款日期 = m.Element("PaidDate").Value,
                           單位 = m.Element("Per").Value,
                           存量 = m.Element("Num").Value,
                           單價 = m.Element("Price").Value,
                           進貨日期 = m.Element("InsideDate").Value,
                       };
            dataGridView1.DataSource = data.ToList();
        }
    }
}
