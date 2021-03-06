 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Double.MaxValue;
            string s = Convert.ToString(x);
            s = s + "1";
            try
            {
                Convert.ToDouble(s);
            }
            catch (FormatException e)
            {
                Console.WriteLine("There is a format exception as the string s is not in a valid format to be converted into a double.");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("There is an overflow exception as the string s represents a number that is too large or small to be stored in the format of a double");
            }
            catch (Exception e)
            {
                Console.WriteLine("The exception raised didn't get caught by anything else so I've caught it here."); 
            }


            Triangle first = new Triangle(2, 1, 4);
            Console.ReadKey();

        }
    }

    class Triangle
    {
        int Length1;
        int Length2;
        int Length3;
        int ZeroDivCheck1;
        int ZeroDivCheck2;
        int ZeroDivCheck3;


        public Triangle(object num1, object num2, object num3)
        {
            try
            {
                
                Length1 = Convert.ToInt32(num1);
                Length2 = Convert.ToInt32(num2);
                Length3 = Convert.ToInt32(num3);
                ZeroDivCheck1 = Length1 / Length2;
                ZeroDivCheck2 = Length2 / Length3;
                ZeroDivCheck3 = Length1 / Length3;
                if ( (Length1 != Math.Abs(Length1))  || (Length2 != Math.Abs(Length2))  || (Length3 != Math.Abs(Length3)))
                {
                    throw new ArgumentException();
                }


            }
            catch (FormatException e)
            {
                Console.WriteLine("There is a format exception as the values passed into the constructor can't be converted into the type integer.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("There is an overflow error as the values passed into the constructor are too large to be stored as integers.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("There is a divide by zero exception as all side lengths of the triangle must be more than 0");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("All side lengths must be greater than 0 and therefore non negative.");
            }
            catch (Exception e)
            {
                Console.WriteLine("A general exception was thrown.");
            }
            
        }


    }
}
