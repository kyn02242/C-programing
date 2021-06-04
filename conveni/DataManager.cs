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

        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                string PersonnelOutput = File.ReadAllText(@"./Personnels.xml");

            }
            catch (FileNotFoundException)
            {
                Save();
            }
        }
        public static void Save()
        {
            string PersonnelOutput = "";
            PersonnelOutput += "<Personnels>\n";
            foreach(var item in Personnels)
            {

            }
        }
    }
}
