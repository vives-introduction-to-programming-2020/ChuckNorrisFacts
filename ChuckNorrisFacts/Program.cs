using ChuckFactsLibrary;
using System;
using System.Net;

namespace ChuckNorrisFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            ChuckNorrisFactShower shower = new ChuckNorrisFactShower();
            //shower.SetProvider(new FactFileLoader());
            shower.SetProvider(new ApiFacts());

            try
            {
                shower.ShowFact();
            }
            catch (WebException we)
            {
                Console.WriteLine("Chuck API unavailable. Switching to backup");
                shower.SetProvider(new FactFileLoader());
                shower.ShowFact();
            }

        }
    }
}
