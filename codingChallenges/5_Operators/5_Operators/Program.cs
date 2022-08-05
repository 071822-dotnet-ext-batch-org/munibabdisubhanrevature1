using System;

namespace _5_OperatorsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Increment(1));
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

       
       
       
}
}

