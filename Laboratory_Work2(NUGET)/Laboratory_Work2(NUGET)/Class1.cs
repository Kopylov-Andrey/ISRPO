using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work2_NUGET_
{
    public class Logger
    {
        public void Log(string text, float number)
        {
            string strnum = number.ToString();
            Console.WriteLine(text + strnum);
        }

    }
}
