using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CustomContainers; // OAA<>

namespace TextAnalysisLibrary
{
    public class WordBench
    {
        private int count_;
        private OAA<string, int, Predicate<int>> frequency_;
        private readonly List<string> infiles_;

        private static void Wordify(string s) 
        {

        }

        public WordBench()
        {
            count_ = 0;
            infiles_ = new List<string>();
            frequency_ = new OAA<string, int, Predicate<int>>();
        }

        /// <summary>
        /// Read a file and store it in memory.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tempString"></param>
        public async Task<string> ReadText(string fileName) 
        {
            String text;
            using (StreamReader inFileReader = File.OpenText(fileName))
            {
                text = await inFileReader.ReadToEndAsync(); 
             //   infiles_.Add(fileName);
            }
            return text;
        }

        public void CleanText()
        {
            
        }
    }
}
