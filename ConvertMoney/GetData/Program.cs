using GetData.Model;
using GetData.Model.GetValute;

using Newtonsoft.Json;
using System;
using System.Net;

namespace GetData
{
    class Program
    {
        static void Main(string[] args)
        {
            var tstPrg = new Program();

            tstPrg.testMethod1();


            Console.WriteLine(new string('\n', 3));
            Console.WriteLine(new string('-', 37));
            Console.WriteLine("The end.");
            Console.ReadKey();
        }


        void testMethod1()
        {
            var dataValute1 = new DataValute();

            string URLAddress = @"https://www.cbr-xml-daily.ru/daily_json.js";
            string response;
            using (var webClient = new WebClient())
            {
                response = webClient.DownloadString(URLAddress);
            }

            //var someVal1 = System.Text.Json.JsonSerializer.Deserialize<object>(response);
            Test test = JsonConvert.DeserializeObject<Test>(response);


            //Console.WriteLine(someVal1);
            Console.WriteLine(test);
            Console.WriteLine(test.Valute["USD"].Value);
            //Console.WriteLine($"Ответочка: {response}");

            //dataValute1.
        }
    }
}
