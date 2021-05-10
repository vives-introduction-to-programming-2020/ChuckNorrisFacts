using System;

namespace ChuckNorrisFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            ChuckNorrisFactShower shower = new ChuckNorrisFactShower();
            shower.SetProvider(new FactFileLoader());

            shower.ShowFact();

        }
    }
}
