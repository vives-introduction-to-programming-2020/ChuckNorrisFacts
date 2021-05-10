using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChuckNorrisFacts
{
    public class FactFileLoader : IFactProvider
    {
        // Load from file
        public FactFileLoader()
        {
            lines = File.ReadAllLines("./facts.txt");
        }

        public string GetFact()
        {
            return lines[random.Next(lines.Length)];
        }

        private string[] lines = new string[0];
        private Random random = new Random();
    }
}
