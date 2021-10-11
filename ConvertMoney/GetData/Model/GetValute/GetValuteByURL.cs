using System.Net;

namespace GetData.Model.GetValute
{
    class GetValuteByURL : IGetValuteByPath
    {

        public DataValute GetListCurrency(string byPath)
        {
            string tmpResponse;
            using (var tmpWebClient = new WebClient())
            {
                tmpResponse = tmpWebClient.DownloadString(byPath);
            }

            return new DataValute();
        }
    }
}
