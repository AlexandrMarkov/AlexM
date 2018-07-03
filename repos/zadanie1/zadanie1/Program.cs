using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\student\\source\\repos\\zadanie1\\file1.txt";
            Class1 class1 = new Class1(path);
            class1.outPutString();
            Console.ReadKey();

        }
    }
}   
