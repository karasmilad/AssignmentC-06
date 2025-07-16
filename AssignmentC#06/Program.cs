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
            int input;
            do
            {
                Console.Write("Enter a number: ");
            }
            while (int.TryParse(Console.ReadLine(), out input));
            int result = SumOfDigits(input);
            Console.WriteLine($"The sum of the digits of the number {input} is: {result}");
            #endregion
        }
    }
}
