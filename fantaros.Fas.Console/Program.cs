using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fantaros.Fas.Parser;
using System.IO;

namespace fantaros.Fas.ScriptConsole
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            string file = AppDomain.CurrentDomain.BaseDirectory+"\\Sample\\sample.fas";
            TextReader txt = new StreamReader(file,true);
            string[] res = FasParser.Parse(txt.ReadToEnd());
            int i = 0;
            foreach (string r in res) 
            {
                Console.WriteLine("{0}:{1}",i,r);
                i++;
            }
            Console.ReadKey();
        }
    }
}
