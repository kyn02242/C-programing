using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
namespace conveni
{
    class DataManager
    {
        public static List<Personnel> Personnels = new List<Personnel>();
        public static List<Receipt> Receipts = new List<Receipt>();

        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                string PersonnelOutput = File.ReadAllText(@"./Personnels.xml");
                XElement PersonnelXElement = XElement.Parse(PersonnelOutput);
                Personnels = (from item in PersonnelXElement.Descendants("personnel")
                              select new Personnel()
                {
                    Id = int.Parse(item.Element("id").Value),
                    Name = item.Element("name").Value,
                    Date = item.Element("date").Value,
                    WorkingTime = item.Element("workingtime").Value,
                    Gender=item.Element("gender").Value,
                    WorkedTime= int.Parse(item.Element("workedtime").Value)
                }).ToList<Personnel>();
                // 추가로 storage 구현을 여기서 사용자도 아마 여기서 할듯
                //string usersOutput = File.
                string ReceiptOutput = File.ReadAllText(@"./Receipts.xml");
                XElement ReceiptXElement = XElement.Parse(ReceiptOutput);
                Receipts = (from item in ReceiptXElement.Descendants("receipt")
                              select new Receipt()
                              {
                                  Id = int.Parse(item.Element("id").Value),
                                  Paid= int.Parse(item.Element("paid").Value),
                                  Pay = int.Parse(item.Element("pay").Value),
                                  Change = int.Parse(item.Element("change").Value)

                              }).ToList<Receipt>();
            }
            catch (FileNotFoundException)
            {
                Save();
            }
        }
        public static void Save()
        {
            string PersonnelsOutput = "";
            PersonnelsOutput += "<Personnels>\n";
            foreach(var item in Personnels)
            {
                PersonnelsOutput += "<personnel>\n";
                PersonnelsOutput += "<id>" + item.Id + "</id>\n";
                PersonnelsOutput += "<name>" + item.Name + "</name>\n";
                PersonnelsOutput += "<date>" + item.Id + "</date>\n";
                PersonnelsOutput += "<workingtime>" + item.WorkingTime + "</workingtime>\n";
                PersonnelsOutput += "<gender>" + item.Gender + "</gender>\n";
                PersonnelsOutput += "<workedtime>" + item.WorkedTime + "</workedtime>\n";
                PersonnelsOutput += "</personnel>\n";

            }
            PersonnelsOutput += "</Personnels>";

            File.WriteAllText(@"./Personnels.xml",PersonnelsOutput);
        }
    }
}
