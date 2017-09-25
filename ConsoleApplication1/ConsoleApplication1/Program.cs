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


             string str = "20+54";

             string pattern = @"\d+";
             Regex regex = new Regex(pattern);

             Match match = regex.Match(str);
             int [] a = new int[2];

             int i = 0;
             while (match.Success)
             {
                 a[i] = Convert.ToInt32(match.Value);
                 match = match.NextMatch();
                 i++;
             }

             Console.WriteLine(a[0]);
             Console.WriteLine(a[1]);


            Console.ReadLine();
        }
    }
}

