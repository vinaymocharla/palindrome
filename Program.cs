using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,rem,rev=0;
            
            num = Convert.ToInt16(Console.ReadLine());
            int temp = num;
            while (num!=0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;

            }
            if(temp==rev)
            {
                Console.WriteLine("the  number is a palindrome");
            }
            else
            {
                Console.WriteLine("the  number is not  a palindrome");

            }
            


        }
    }
}
