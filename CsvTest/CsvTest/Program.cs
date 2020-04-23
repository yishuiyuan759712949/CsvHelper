using CsvHelper;
using CsvHelper.Configuration;
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
           


                SimpleTest test = new SimpleTest();
                //test.Write();
            List<SimpleTest> ls = new List<SimpleTest>();
            for (int i = 0; i < 10; i++)
            {
                SimpleTest t = new SimpleTest();
                t.Id = i + 1;
                t.Name = test.Id.ToString();
                ls.Add(t);
            }
            test.WriteNewLine(ls);



            //for (int i = 0; i < 10; i++)
            //{
            //    PhoneModel phoneModel = new PhoneModel();
            //    phoneModel.SN = "GOW123456789";
            //    phoneModel.Time = DateTime.Now.ToString("dddd_MMMM_dd_yyyy");
            //    phoneModel.FistFailItem = "EarMic";
            //    phoneModel.TestItem = new List<string>()
            //    {
            //        "Mic",
            //        "Hock"
            //    };
            //    phoneModel.Write("phoneModel.csv", phoneModel);

            //}


            Console.Read();
        }
     

    }
    
}
