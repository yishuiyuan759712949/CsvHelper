using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTest
{
    class PhoneModel
    {
        public string SN
        {   get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string FistFailItem
        {
            get;
            set;
        }
        public List<string> TestItem
        {
            get;
            set;
        }

        public void Write(string path, PhoneModel phoneModel)
        {
            var records = new List<PhoneModel>
            {
                phoneModel
            };
            string filePathCsv = path;
            using (var writer = new StreamWriter(filePathCsv, true))//覆盖模式
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
