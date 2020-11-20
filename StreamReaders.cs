using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

namespace Lecteur_C
{
    class StreamReaders
    {
        public static void Read()
        {
            string path = @"C:\Users\chris\Desktop\Subtitle.srt";
            string line = "";

            using StreamReader sr = new StreamReader(path);

            while ((line = sr.ReadLine()) != null)
                Regex. ; 
        }
    }
       
}
