using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckFactsLibrary
{
    public class HardcodedFacts : IFactProvider
    {
        public HardcodedFacts()
        {
            quotes.Add("Chuck Norris knows Victoria's secret.");
            quotes.Add("Chuck Norris counted to infinity. Twice.");
            quotes.Add("When Chuck Norris enters a room, he doesn't turn the lights on, he turns the dark off.");
            quotes.Add("Death once had a near-Chuck-Norris experience.");
        }
        
        public string GetFact()
        {                            // [0, max[
            return quotes[random.Next(quotes.Count)];
        }

        private List<string> quotes = new List<string>();
        private Random random = new Random();
    }
}
