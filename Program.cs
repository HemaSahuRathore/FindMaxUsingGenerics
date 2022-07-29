namespace FindMaxProblemUsingGenerics
{ /// <summary>
  /// Refactor1 : Refactor all the 3 to One Generic Method and find the maximum
  /// </summary>
    internal class Program
    {
        //An entrypoint of main program
        static void Main(string[] args)
        {
            //Integers variables
            int val1 = 85, val2 = 78, val3 = 95;

            //Float variables
            float val4 = 85.35f, val5 = 78.85f, val6 = 95.78f;

            //String variables
            string val7 = "Apple", val8 = "Peach", val9 = "Banana";

            //Displaying max value for Integers
            Console.WriteLine("\nThe Maximum value of Integer out of {0}, {1} and {2} is {3}", val1, val2, val3, GenericClassToFindTheMax<int>.FindTheMaxValue(val1, val2, val3));
            //Displaying max value for Floats
            Console.WriteLine("\nThe Maximum value of Float out of {0}, {1} and {2} is {3}", val4, val5, val6, GenericClassToFindTheMax<float>.FindTheMaxValue(val4, val5, val6));
            //Displaying max value for Strings
            Console.WriteLine("\nThe Maximum value of string out of {0}, {1} and {2} is {3}", val7, val8, val9, GenericClassToFindTheMax<string>.FindTheMaxValue(val7, val8, val9));

        }
    }
}