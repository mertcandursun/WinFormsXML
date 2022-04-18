using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace WinFormsXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            /* XML dosyamın oluşacak yolunu proje yolu olarak belirttim */
            string xmlPath = Application.StartupPath + "\\Customer.xml";

            //Yazıcı nesnemi ve formatımı oluşturdum.
            XmlWriter customer = new XmlTextWriter(xmlPath, UTF8Encoding.UTF8);

            //customer.Formatting = Formatting.Indented;

            customer.WriteStartDocument();

            customer.WriteStartElement("Müşteriler");
            customer.WriteStartElement("Müşteri");

            customer.WriteStartAttribute("ID", "1");

            customer.WriteElementString("isim", textBox1.Text);
            customer.WriteElementString("soyisim", textBox2.Text);

            customer.WriteEndElement();
            customer.WriteEndElement();

            customer.Close();
            MessageBox.Show("İşleminiz tamamlandı.");
            Application.Exit();
        }
    }
}
