
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    internal class alp_digit_splch
    {
        static void Main(string[] args)
        {
            string str;
            int alp, digit, splch, i, l;
            alp = digit = splch  = i = 0;

            Console.WriteLine("\n\n count total number of alp char and digits\n\n");
            Console.WriteLine("--------------------------------------------------\n");
            Console.WriteLine("input string");
            str = Console.ReadLine();
            l = str.Length;
             // check each charactor of a string
             while(i< l)
            {
                if ((str[i] >= 'a'&& str[i] <= 'z') || (str[i] >= 'A' && str[i] <='Z'))  
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i]<='9') 
                {
                    digit++;
                }
                else
                {
                    splch++;
                }
                i++;
            }
            Console.WriteLine("number of alphabets:{0}\n", alp);
            Console.WriteLine("number of digits:{0}\n",digit);
            Console.WriteLine("number of special charactor in the string:{0}\n", splch);
        }
    }
}
