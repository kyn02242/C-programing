using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace conveni
{
    public class Storage
    {
        private void Read_Write()
        {
            string temp = "";

            XmlTextWriter Merchant = new XmlTextWriter("D:\\help.xml", Encoding.UTF8);

            Merchant.Formatting = Formatting.Indented;

            Merchant.WriteStartDocument();
            Merchant.WriteStartElement("root");

            Merchant.WriteStartElement("hello");




        }
    }
}
