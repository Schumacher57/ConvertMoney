using GetData.Model;
using GetData.Model.GetValute;

using Newtonsoft.Json;
using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace GetData
{
    class Program
    {
        static void Main(string[] args)
        {
            var tstPrg = new Program();

            tstPrg.testMethod2();


            Console.WriteLine(new string('\n', 3));
            Console.WriteLine(new string('-', 37));
            Console.WriteLine("The end.");
            Console.ReadKey();
        }



        void testMethod2()
        {
            var dataValute = new StorageValute();
            var valute = dataValute.Valute;
            dataValute.GetValute(@"https://www.cbr-xml-daily.ru/daily_json.js");
            Console.WriteLine($"{dataValute.Valute["USD"].LongName}");
            Console.WriteLine($"{dataValute.Valute["USD"].Value}");
            


        }

        void testMethod1()
        {
            //var dataValute1 = new DataValute();

            string URLAddress = @"https://www.cbr-xml-daily.ru/daily_json.js";
            string response;
            using (var webClient = new WebClient())
            {
                response = webClient.DownloadString(URLAddress);
            }

            //var someVal1 = System.Text.Json.JsonSerializer.Deserialize<object>(response);
            StorageValute test = JsonConvert.DeserializeObject<StorageValute>(response);

            Console.WriteLine(test);
            Console.WriteLine(test.Valute["USD"].LongName);
            test.Valute.ToList().ForEach(x => Console.WriteLine($"Знач.: {x}"));

        }
    }
    public class KissMyAss

    {
    }
}
