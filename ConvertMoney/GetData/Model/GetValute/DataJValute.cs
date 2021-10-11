using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GetData.Model.GetValute
{
    class DataJValute
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("ID")]
        public string ID { get; set; }
        [JsonProperty("Value")]
        public decimal Value { get; set; }



    }

    class Test
    {
        [JsonProperty("Valute")]
        public Dictionary<string, DataJValute> Valute { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }

    }


}
