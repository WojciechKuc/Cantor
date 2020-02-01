using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor
{
    class USDPLN : ICantorInterface
    {
           public double Calculate(double value)
           {
               RestClient restClient = new RestClient("https://api.ratesapi.io/");
               RestRequest restRequest = new RestRequest("api/latest?base=USD&symbols=PLN", Method.GET);


               IRestResponse restResponse = restClient.Execute(restRequest);
               string response = restResponse.Content;
               string response_cut = response.Substring(29, 4);
               double kurs = double.Parse(response_cut, System.Globalization.CultureInfo.InvariantCulture);
               return value * kurs;
           }
        
    }
}
