using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisFacts
{
    public class ChuckNorrisFactShower
    {
        // This can show the message
        public void ShowFact()
        {
            Console.WriteLine(generator.GetFact());
        }

        public void SetProvider(IFactProvider provider)
        {
            this.generator = provider;
        }

        private IFactProvider generator = new HardcodedFacts();
    }
}
