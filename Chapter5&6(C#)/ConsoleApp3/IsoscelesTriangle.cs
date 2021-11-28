using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding =Encoding.UTF8;
        char copyRight = '\u00A9';
        Console.WriteLine("{0,0}{0,9}\n " +
            "{0,1}{0,7}\n " +
            "{0,2}{0,5}\n " +
            "{0,3}{0,3}\n " +
            "{0,4}{0,1}\n",
                          copyRight);
    }
}
