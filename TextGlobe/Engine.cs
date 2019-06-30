using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextGlobe
{
    class Engine
    {
        private Regex rgx = new Regex("[^a-zA-Z0-9]");
        private List<string> stopWords = new List<string>();
        private BST tree;

        public Engine()
        {
            stopWords.AddRange(File.ReadAllLines("StopWords.txt"));
        }

        public void ScanFiles(string[] filesList)
        {
            this.tree = new BST();
            foreach (string filename in filesList)
            {
                var lines = File.ReadAllLines(filename);
                for (int l = 0; l < lines.Length; l++)
                {
                    foreach (string word in lines[l].Split(' '))
                    {
                        string noPunc = preprocessWord(word);
                        if (!stopWords.Contains(noPunc) && noPunc.Length > 1 && !int.TryParse(noPunc, out int n))
                            tree.Insert(noPunc, filename + " : " + l);
                    }
                }
            }
        }

        public List<string> Query(string queryString)
        {
            List<HashSet<string>> aggregated = new List<HashSet<string>>();
            foreach (string qWord in queryString.Trim().Split(' '))
            {
                string noPunc = preprocessWord(qWord);
                if (stopWords.Contains(noPunc) || noPunc.Length < 2)
                    continue;
                Node foundNode = tree.FindNode(noPunc);
                if (foundNode != null)
                    aggregated.Add(foundNode.OccuranceList);
            }

            if (aggregated.Count == 0)
                return new List<string>();

            HashSet<string> intersecred = new HashSet<string>();
            intersecred = aggregated[0];
            if (aggregated.Count > 1)
                for (int i = 1; i < aggregated.Count; i++)
                    intersecred.IntersectWith(aggregated[i]);

            List<string> finalResult = intersecred.ToList();
            for (int i = 0; i < intersecred.Count; i++)
            {
                int colonIndex = finalResult[i].LastIndexOf(':');
                string filename = finalResult[i].Substring(0, colonIndex);
                int skips = int.Parse(finalResult[i].Substring(colonIndex + 1));
                string line = File.ReadLines(filename).Skip(skips).Take(1).First();
                finalResult[i] = ">> " + finalResult[i] + "\r\n..." + line + "...\r\n";
            }

            return finalResult;
        }

        private string preprocessWord(string word)
        {
            return rgx.Replace(word, "").ToLower();
        }
    }
}
