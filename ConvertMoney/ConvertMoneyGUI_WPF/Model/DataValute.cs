using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using GetData.Model.GetValute;

namespace GetData.Model
{

    /// <summary>
    /// Класс - хранилизе валют
    /// </summary>
    class StorageValute
    {
        protected IGetValuteByPath getValuteBehavior;

        [JsonProperty("Valute")]
        public Dictionary<string, DataValute> Valute { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Получение списка валюты по указанному пути
        /// </summary>
        /// <param name="path">Путь к списку валюты в формате JSON. Указать URL</param>
        public void GetValute(string path)
        {
            var tmpStorage = new StorageValute();
            tmpStorage = getValuteBehavior.GetValute(path);
            Valute = tmpStorage.Valute;
            Date = tmpStorage.Date;
        }

        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public StorageValute()
        {
            getValuteBehavior = new GetValuteByURL();   // Способ получния валюты по-умолчанию
        }

        /// <summary>
        /// Установка типа получения значений по указанному адресу. По-умолчанию это URL ссылка
        /// </summary>
        /// <param name="getValuteBehavior">класс наследующий поведение получения данных из сторки адреса</param>
        public void SetBehaviorGet(IGetValuteByPath getValuteBehavior)
        {
            this.getValuteBehavior = getValuteBehavior;
        }

        #region Класс хранитель конкретной валюты
        /// <summary>
        /// Класс со свойством конкретной валюты
        /// </summary>
        internal class DataValute
        {

            /// <summary>
            /// Значение с ID валюты. Тип: string
            /// </summary>
            [JsonProperty("ID")]
            public string ID { get; set; }

            /// <summary>
            /// Код валюты. Обязательно string! - т.к. можно потерять нули вначале!
            /// </summary>
            [JsonProperty("NumCode")]
            public string NumCode { get; set; }

            /// <summary>
            /// Свойство и коротим именем валюты
            /// </summary>
            [JsonProperty("CharCode")]
            public string ShortName { get; set; }

            /// <summary>
            /// Номинал валюты
            /// </summary>
            [JsonProperty("Nominal")]
            public int Nominal { get; set; }

            /// <summary>
            /// Знчение с полным наименованием валюты
            /// </summary>
            [JsonProperty("Name")]
            public string LongName { get => longName; set => longName = value; }
            private string longName;

            /// <summary>
            /// Цена валюты (по отношению к рублю)
            /// </summary>
            [JsonProperty("Value")]
            public decimal Value
            {
                get => pValue;
                set
                {
                    if (decimal.TryParse(value.ToString(), out pValue))
                    {
                        pValue = pValue < 0 ? 0 : value;
                    }
                    else
                    {
                        pValue = 0;
                    }
                }
            }
            private decimal pValue = 0;

            /// <summary>
            /// Предыдущее значение валюты
            /// </summary>
            [JsonProperty("Previous")]
            public decimal PreviousVal
            {
                get => previousVal;
                set
                {
                    if (decimal.TryParse(value.ToString(), out previousVal))
                    {
                        previousVal = previousVal < 0 ? 0 : value;
                    }
                    else
                    {
                        previousVal = 0;
                    }
                }
            }
            private decimal previousVal;




        }
        #endregion
    }

    public class someClass

    { }


}
