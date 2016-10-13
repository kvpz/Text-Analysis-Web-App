using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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
        private OAA<string, int> frequency_;
        private readonly List<string> infiles_;

        private static void Wordify(string s) //fsu::String& s);
        {

        }

        public WordBench()
        {
            count_ = 0;
            infiles_ = new List<string>();
        }

        public bool ReadText(string fileName, out string tempString) //const fsu::String& infile);
        {
            FileStream inFileStream;
            tempString = "blank string";
            try
            {
                inFileStream = File.Open(fileName, FileMode.Open);

            }
            catch (FileNotFoundException e)
            {
                tempString = e.Message;
                return false;
            }
            
            StreamReader fileStreamReader = new StreamReader(inFileStream); // works well
            //tempString = sReader.ReadToEnd();
            //StringReader stringReader = new StringReader(inFileStream.);
            infiles_.Add(fileName);
            uint wordsRead = 0;
            // str = new StringReader(inFileStream.ToString());
            string words = new Str;
            
            while ( fileStreamReader.BaseStream.CanRead)//!fileStreamReader.EndOfStream )//&& (words = fileStreamReader.ReadLine()) != null)
            {

                words = fileStreamReader.ReadLine();
                if(words.Length < 1)
                tempString = words;

            }
            //fileStreamReader.Dispose();
            //inFileStream.Dispose();
            // fileStreamReader.Dispose();
            
            return true;
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
