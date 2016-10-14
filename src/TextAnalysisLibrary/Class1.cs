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
        /*
        typedef fsu::String             KeyType;
        typedef size_t                  DataType;

  size_t count_;  //number of valid words read
        fsu::OAA<KeyType, DataType> frequency_;
        fsu::List<fsu::String> infiles_;
        */
        //alias string KeyType;
        //alias int DataType;

        private int count_;
        private OAA<string, int, Predicate<int>> frequency_;
        private readonly List<string> infiles_;

        private static void Wordify(string s) //fsu::String& s);
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
        public async Task<string> ReadText(string fileName) //const fsu::String& infile);
        {
            String text;
            using (StreamReader inFileReader = File.OpenText(fileName))//OpenText(fileName)) StreamReader
            {
                text = await inFileReader.ReadToEndAsync(); 
                infiles_.Add(fileName);
            }
            return text;
        }

        public void CleanText()
        {
            
        }
        /*
  bool WriteReport(const fsu::String& outfile, unsigned short kw = 15, unsigned short dw = 15,
                   std::ios_base::fmtflags kf = std::ios_base::left, // key justify
                   std::ios_base::fmtflags df = std::ios_base::right // data justify
                     ) const;
        void ShowSummary() const;
        void ClearData();
        */
        


    }
}
