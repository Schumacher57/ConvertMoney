using System;
using System.Collections.Generic;
using System.Text;
using GetData.Model.GetValute;

namespace GetData.Model
{
    class DataValute
    {

        protected IGetValuteByPath getValute;

        private string id;
        private int numCode;
        private string charCode;
        private long nominal;
        private string longName;
        private decimal value;
        private decimal previousVal;

        public string Id { get => id; set => id = value; }
        public int NumCode { get => numCode; set => numCode = value; }
        public string CharCode { get => charCode; set => charCode = value; }
        public long Nominal { get => nominal; set => nominal = value; }
        public string LongName { get => longName; set => longName = value; }
        /// <summary>
        /// Значение валюты. Тип Decimal
        /// </summary>
        public decimal Value
        {
            get => value;
            set
            {
                /*if (value < 0 || decimal.TryParse(value)==false)
                    this.value = value;*/
            }

        }
        public decimal PreviousVal { get => previousVal; set => previousVal = value; }

        public void GetData(string URLPath)
        {
            var tmpGetURL = new DataValute();
            tmpGetURL = getValute.GetListCurrency(URLPath);
        }

        public DataValute()
        {
            this.getValute = new GetValuteByURL();

        }


    }
}
