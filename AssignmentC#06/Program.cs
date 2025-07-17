namespace AssignmentC_06
{
    internal class Program
    {
        public static void calculator(int a, int b, int c, int d)
        {
            int summation = a + b;
            int subtracting = c - d;
            Console.WriteLine($"The Summation is : {summation}");
            Console.WriteLine($"The Subtracting is : {subtracting}");
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        public static string isPrime(int number)
        {
            if (number <= 1) return "Not Prime";
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return "Not Prime";
            }
            return "Prime";
        }
        public static int[] MinMaxArray(ref int[] arr)
        {
            Array.Sort(arr);
            int min = arr[0];
            int max = arr[arr.Length - 1];
            int[] returnValue = { min, max };
            return returnValue;
        }
        public static void factorialNumber(uint number)
        {
            uint result = 1;
            for (uint i = 1; i<= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            #region Question01
            //Value Type
            //1)Passing by value means that a copy of the variable is passed to the method.
            //2)Passing by reference means that a reference to the variable is passed to the method.
            #endregion
            #region Question02
            //Reference Type
            //1)Passing by value means that a copy of the reference to the object is passed to the method.
            //2)Passing by reference means that a reference to the reference of the object is passed to the method.
            #endregion
            #region Question03
            //calculator(5,10,20,10);
            #endregion
            #region Question04
            //int input;
            //do
            //{
            //    Console.Write("Enter a number: ");
            //}
            //while (int.TryParse(Console.ReadLine(), out input));
            //int result = SumOfDigits(input);
            //Console.WriteLine($"The sum of the digits of the number {input} is: {result}");
            #endregion
            #region Question05
            //Console.WriteLine(isPrime(10));
            #endregion
            #region Question06
            //int[] ints = { 20, 30, 0, 60, 80, -1 };
            //int[] minMax = MinMaxArray(ref ints);
            //Console.WriteLine($"Minimum: {minMax[0]}, Maximum: {minMax[1]}");
            #endregion
            #region Question07
            //factorialNumber(10);
            #endregion
        }
    }
}
