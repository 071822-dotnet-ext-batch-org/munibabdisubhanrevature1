using System;

namespace _5_OperatorsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Diff(16, 16));
        }

        /// <summary>
        /// This method takes an int and returns the int incremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Increment(int num)
        {
            
            return num++;
            //throw new NotImplementedException($"Increment() is not implemented yet.");
        }


        public static int Decrement(int num)
        {
            return num--; 
        }

        public static bool Not (bool input)
        {
            if (input)
            {
                return false;
            }
             else 
             {
                return true;
             }
        }
       
       public static int Negate(int num)
       {
        if (num > 0) 
        {
            int negative = num + (num * -2);
            return negative;
        }
        return num;
    }
    public static int sum(int num1, int num2)
    {
        int addTwoNumbers = num1 + num2;
        return addTwoNumbers;
    }

    public static int Diff(int number1, int number2)
    {
        int subtractTwoNumbers = number1 - number2;
        return subtractTwoNumbers;
    }

    public static int Product(int number1, int number2)
    {
        int productTwoNumbers = number1 * number2;
        return productTwoNumbers;
    }
    
    public static int Quotient(int number1, int number2)
    {
        int quotientTwoNumbers = number1 / number2;
        return quotientTwoNumbers;

    }

    public static int Remainder(int number1, int number2) 
    {
        int remainderTwoNumbers = number1 % number2;
        return remainderTwoNumbers;
    }

    public static bool And(int firstnumber, int secondnumber)
    {
        if (firstnumber != 0 && firstnumber > secondnumber)
        {
            return true;
        }
        return false;

    }

    public static bool Or(int number1, int number2)
    {
    
    if (number1 == number2 || number1 < 0)
    {
        return true;
    }
    return false;
    }

    
}
}


