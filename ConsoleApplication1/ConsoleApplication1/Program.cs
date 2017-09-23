using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = String.Empty;
            //StringBuilder sb = new StringBuilder().Append(String.Empty);
            int str2 = String.Intern(str1);

            //if (object.ReferenceEquals(str1, str2))
           //     Console.WriteLine("Equal");
          //  else
          Console.WriteLine(str2);

            Console.ReadLine();
        }
    }
}