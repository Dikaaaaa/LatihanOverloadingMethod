using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {

        int jadi;
        public int FindMinimum(int number1, int number2)
        {
            if (number1 < number2)
            { 
                jadi = number1;
            }
            if (number1 > number2)
            { 
                jadi = number2;
            }


            return jadi;
            
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            if ((number1 < number2) && (number1 < number3))
            {
                jadi = number1;
            }
            else if  ((number2 < number1) && (number2 < number3))
            {
                jadi = number2;
            }
            else if  ((number3 < number1) && (number3 < number2))
            {
                jadi = Convert.ToInt32(number3);
            }

            return jadi;
        }

        public int FindMaximum(int number1, int number2)
        {
            if (number1 > number2)
            {
                jadi = number1;
            }
            if (number1 < number2)
            {
                jadi = number2;
            }
            return jadi;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            if ((number1 > number2) && (number1 > number3)) 
            {
                jadi = number1;
            }
            if ((number2 > number1) && (number2 > number3)) 
            {
                jadi = number2;
            }
            if ((number3 > number1) && (number3 > number2))
            {
                jadi = Convert.ToInt32(number3);
            }

            return jadi;
        }
    }
}
