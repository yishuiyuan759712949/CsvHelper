using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTest
{
    class SimpleTest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 写一条内容，含标题
        /// </summary>
        public void Write()
        {
            string filePathCsv = "Test.csv";
            var records = new List<SimpleTest>
            {
                new SimpleTest { Id = 10, Name = "then" },
            };
            using (var writer = new StreamWriter(filePathCsv, true))//覆盖模式
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
        /// <summary>
        /// 写一条内容，不含标题
        /// </summary>
        /// <param name="simpleTests"></param>
        public void WriteNewLine(List<SimpleTest> simpleTests)
        {
            string filePathCsv = "Test.csv";
            using (var writer = new StreamWriter(filePathCsv, true))//覆盖模式
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {

                foreach (var item in simpleTests)
                {
                    csv.WriteRecord(item);
                    csv.NextRecord();
                }

            }

         
            
        }

        public void Read()
        {
            string filePathCsv = "Test.csv";
            using (var reader = new StreamReader(filePathCsv, Encoding.GetEncoding("GB2312")))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<dynamic>();
                foreach (var item in records)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
