
///Получение данных с сервера
string URLAddress = @"https://www.cbr-xml-daily.ru/daily_json.js";
string response;
using (var webClient = new WebClient())
{
    response = webClient.DownloadString(URLAddress);
}

// Десериализация данных:
Test test = JsonConvert.DeserializeObject<Test>(response);

// Получение значения по имени валюты в словаре:
Console.WriteLine(test.Valute["USD"].Name);