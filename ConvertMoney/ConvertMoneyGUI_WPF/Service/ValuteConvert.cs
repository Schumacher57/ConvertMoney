using ConvertMoneyGUI_WPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConvertMoneyGUI_WPF.Service
{
    class ValuteConvert : INotifyPropertyChanged
    {
        private StorageValute storageValute { get; set; }

        private StorageValute.DataValute activeValuteOne;   // Поля с корткими именами слева
        private StorageValute.DataValute activeValuteTwo;   // Поля с корткими именами справа   

        private string shortNameOne;
        private string shortNameTwo;
        public string ShortNameOne { get => shortNameOne; set { shortNameOne = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ShortNameOne")); } }
        public string ShortNameTwo { get => shortNameTwo; set { shortNameTwo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ShortNameTwo")); } }

        /// <summary>
        /// Валюта слева
        /// </summary>
        public StorageValute.DataValute ActiveValuteOne
        {
            get => activeValuteOne;
            set { activeValuteOne = value; ShortNameOne = value.ShortName; }
        }

        /// <summary>
        /// Валюта справа
        /// </summary>
        public StorageValute.DataValute ActiveValuteTwo { get => activeValuteTwo; set { activeValuteTwo = value; ShortNameTwo = value.ShortName; } }
        public List<string> ListValutes { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Метод события изменения свойсва
        /// </summary>
        /// <param name="propertyName">Имя инициализировавшее изменения события</param>

        // Конструктор по-умолчанию
        public ValuteConvert()
        {
            storageValute = new StorageValute();
            storageValute.GetValute(@"https://www.cbr-xml-daily.ru/daily_json.js");
            ListValutes = new List<string>();
            ListValutes = storageValute.Valute.Keys.ToList();
            ActiveValuteOne = storageValute.Valute["USD"];  // Присваимваем defailt значения валютам для конвертации из одной в другую
            ActiveValuteTwo = storageValute.Valute["GBP"];  // Присваимваем defailt значения валютам для конвертации из одной в другую

        }

        /// <summary>
        /// Метод возвращающий тип "Валюта" по короткому имени
        /// </summary>
        /// <param name="ShortName"></param>
        /// <returns>Вернёт тип "Valute" (словарь)</returns>
        public StorageValute.DataValute SetValuteByShortName(string ShortName)
        {
            return storageValute.Valute[ShortName];
        }

        /// <summary>
        /// Метод конвертации валюты
        /// </summary>
        /// <param name="valuteOne"> Активаная валюта</param>
        /// <param name="valuteTwo"> Валюта в которую нужно конвертировать </param>
        /// <param name="inputValue"> Значение конвертируемой валюты</param>
        /// <returns> Возвращаем string значение результата конвертации</returns>
        public string ConvertVlaute(StorageValute.DataValute valuteOne, StorageValute.DataValute valuteTwo, string inputValue)
        {
            try
            {
                return Math.Round(decimal.Parse(inputValue) * ((decimal)valuteOne.Value / (decimal)valuteTwo.Value) * ((decimal)valuteTwo.Nominal / (decimal)valuteOne.Nominal), 2).ToString();
            }
            catch
            {
                return "nan";
            }

        }


    }
}
