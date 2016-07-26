using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prowork
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            char q;
            int count = 0;
            Console.WriteLine("Enter the string");
            p = Console.ReadLine();
           
            foreach (char t in p)
            {
                
                q = char.ToUpper(t);

                if (t == q)
                {
                    count += 1;
                    
                }
               
            }
            Console.WriteLine(count+1);
            Console.ReadLine();
        }
    }
}
