using System.Net;
using Newtonsoft.Json;

namespace GetData.Model.GetValute
{
    class GetValuteByURL : IGetValuteByPath
    {
        StorageValute IGetValuteByPath.GetValute(string byPath)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    return JsonConvert.DeserializeObject<StorageValute>(webClient.DownloadString(byPath));
                }

            }
            catch
            {
                return new StorageValute();
            }
        }
    }
}
