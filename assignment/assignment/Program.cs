using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment
{
    class Program
    {

        static void Main(string[] args)
        {

          Console.WriteLine("Enter String :   ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter period :   ");
           int period = Convert.ToInt32(Console.ReadLine());

            Program objp = new Program();

           int replacement = objp.Return(period, str);

            Console.WriteLine("No of replacement    :   " + replacement);
            Console.ReadLine();
        }
        

        public int Return (int maxPeriod, string str)
        {
            int r = 0;
            int period = maxPeriod;
            int[] arr = new int[maxPeriod];

            while (period != 0)
            {
                for (int j = 0; j < period; j++)
                {
                    for (int i = j; i < str.Length - period; i = i + period)
                    {

                        if (str[j] != str[i + period])
                        {
                            r++;

                        }
                    }
                }

                arr[period - 1] = r;
                period--;

            }
            Array.Sort(arr);
            return arr[0];
        
        }
    }

}
