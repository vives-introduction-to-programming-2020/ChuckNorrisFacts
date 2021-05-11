using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ChuckFactsLibrary
{
    public class ApiFacts : IFactProvider
    {
        public string GetFact()
        {
            string json = HttpHelper.Get("https://api.chucknorris.io/jokes/random");

            //JObject details = JObject.Parse(json);
            //string fact = details.Value<string>("value");

            dynamic details = JObject.Parse(json);
            string fact = details.value;

            return fact;
        }
    }
}
