using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    internal class Program
    {
        void LoadTemplates(string fileName)
        {
            bool templatesFileExist =
                File.Exists(fileName);
            Debug.Assert(templatesFileExist, "Can't load templates file:" + fileName);
        }
        static void Main(string[] args)
        {
        }
    }
}
