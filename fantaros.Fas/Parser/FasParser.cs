using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Parser
{
    public class FasParser
    {
        public static string[] Parse(string content)
        {
            return content.Split(new string[] { ";", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
