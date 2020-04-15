using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CsvTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Read();
            Console.Read();
        }
        public static void Read()
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
        public static void Write()
        {
            string filePathCsv = "Test.csv";
            var records = new List<Test>
            {
                new Test { Id = 10, Name = "then" },
            };
            using (var writer = new StreamWriter(filePathCsv,false))//覆盖模式
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }

    class Test
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

}
