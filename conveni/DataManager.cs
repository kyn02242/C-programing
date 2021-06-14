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
        public static List<Storage> Storages = new List<Storage>();
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
                                  Gender = item.Element("gender").Value

                              }).ToList<Personnel>();


                // 추가로 storage 구현을 여기서 사용자도 아마 여기서 할듯
                //string usersOutput = File.
                string ReceiptOutput = File.ReadAllText(@"./Receipts.xml");
                XElement ReceiptXElement = XElement.Parse(ReceiptOutput);
                Receipts = (from item in ReceiptXElement.Descendants("receipt")
                            select new Receipt()
                            {
                                Id = int.Parse(item.Element("id").Value),
                                Paid = int.Parse(item.Element("paid").Value),
                                Pay = int.Parse(item.Element("pay").Value),
                                Change = int.Parse(item.Element("change").Value)

                            }).ToList<Receipt>();


                string StorageOutput = File.ReadAllText(@"./Storages.xml");
                XElement StorageXElement = XElement.Parse(ReceiptOutput);
                Storages = (from item in StorageXElement.Descendants("storage")
                            select new Storage()
                            {
                                Id = int.Parse(item.Element("id").Value),
                                Name = item.Element("name").Value,
                                Count = int.Parse(item.Element("count").Value)


                            }).ToList<Storage>();
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
            foreach (var item in Personnels)
            {
                PersonnelsOutput += "<personnel>\n";
                PersonnelsOutput += "   <id>" + item.Id + "</id>\n";
                PersonnelsOutput += "   <name>" + item.Name + "</name>\n";
                PersonnelsOutput += "   <date>" + item.Id + "</date>\n";
                PersonnelsOutput += "   <workingtime>" + item.WorkingTime + "</workingtime>\n";
                PersonnelsOutput += "   <gender>" + item.Gender + "</gender>\n";

                PersonnelsOutput += "</personnel>\n";

            }
            PersonnelsOutput += "</Personnels>";

            string ReceiptsOutput = "";
            ReceiptsOutput = "";
            ReceiptsOutput += "<receipts>\n";
            foreach (var item in Receipts)
            {
                ReceiptsOutput += "<receipt>\n";
                ReceiptsOutput += " <Id>" + item.Id + "</Id>\n";
                ReceiptsOutput += " <Year>" + item.Year + "</Year>\n";
                ReceiptsOutput += " <Month>" + item.Month + "</Month>\n";
                ReceiptsOutput += " <Date>" + item.Date + "</Date>\n";

                ReceiptsOutput += " <Paid>" + item.Paid + "</Paid>\n"; // 지불해야 하는 금액
                ReceiptsOutput += " <Pay>" + item.Pay + "</Pay>\n"; // 지불된 금액
                ReceiptsOutput += " <Change>" + item.Change + "</Change>\n";
            }
            ReceiptsOutput += "</receipts>";


            string StoragesOutput = "";
            StoragesOutput = "";
            StoragesOutput += "<storages>\n";
            foreach (var item in Storages)
            {
                StoragesOutput += "<storage>\n";
                StoragesOutput += " <Id>" + item.Id + "</Id>\n";
                StoragesOutput += " <Name>" + item.Name + "</Name>\n";
                StoragesOutput += " <Count>" + item.Count + "</Count>\n";


            }
            ReceiptsOutput += "</storages>";


            File.WriteAllText(@"./Storages.xml", StoragesOutput);
            File.WriteAllText(@"./Receipts.xml", ReceiptsOutput);
            File.WriteAllText(@"./Personnels.xml", PersonnelsOutput);
        }
    }
}
