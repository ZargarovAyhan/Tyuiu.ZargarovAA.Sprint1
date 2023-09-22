using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZargarovAA.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14

    {
        public double ReverseNumber(double number)
        {
            string numberString = number.ToString();
            char[] charArray = numberString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = string.Concat(charArray);
            double reversedNumber = double.Parse(reversedString);
            return reversedNumber;
        }
    }
}
