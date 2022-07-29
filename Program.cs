namespace FindMaxProblemUsingGenerics
{ /// <summary>
  /// UC1 : Given 3 Integers find the maximum
  /// </summary>
    internal class Program
    {
        //An entrypoint of main program
        static void Main(string[] args)
        {
            //Integers variables
            int val1 = 85, val2 = 78, val3 = 95;

           //Displaying max value for Integers
            Console.WriteLine("\nThe Maximum value of Integer out of {0}, {1} and {2} is {3}", val1, val2, val3, FindTheMax.FindTheMaxValue(val1, val2, val3));
            
        }
    }
}