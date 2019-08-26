using System.Runtime.ConstrainedExecution;
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Math math = new Math("the number: ");
            int i;
            double[] arr = new double[100];
            i = 0;
            do{
                arr[i] = Convert.ToDouble(Console.ReadLine());
                i = i+1;
             
                
            }while(Console.ReadLine()!="/");
            Console.WriteLine("Sum: {0}",math.Sum(arr[i]));
            // Console.WriteLine("Multiply: {0}",math.Multiply(12,10,1));
            // Console.WriteLine("Substract: {0}",math.Substract(12,10,1));
            // Console.WriteLine("Division: {0}",math.Division(12,10,1));

        }
    }
    class Math
    {
        public double sum;
       
        public Math(string enter)
        { 
            Console.WriteLine(enter);
        }
        public double Sum(params double[] numbers)
        {
            sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }
            return sum;
        }
        public double Multiply(params double[] numbers)
        {
            sum = 1;
            foreach (double i in numbers)
            {
                sum *= i;
            }
            return sum;
        }
        public double Substract(params double[] numbers)
        {
            sum = numbers[0];
            foreach (double i in numbers)
            {
                if (i == numbers[0])
                {
                    continue;
                }
                sum -= i;
            }
            return sum;
        }
        public double Division(params double[] numbers)
        {
            sum = numbers[0];
            foreach (double i in numbers)
            {
                if (i == numbers[0])
                {
                    continue;
                }
                sum /= i;
            }
            return sum;
        }
    }
}