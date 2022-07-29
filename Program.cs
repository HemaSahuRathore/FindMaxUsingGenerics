namespace FindMaxProblemUsingGenerics
{ /// <summary>
  /// Refactor2 : Refactor to create Generic Class to take in 3 variables of Generic Type
  ///- Ensure the Generic Type extends Comparable
  ///- Write parameter constructor
  ///- Write testMaximum method to internally call the static testMaximum method passing the 3 instance variables
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

            GenericClassToFindTheMax<int> intergerObj = new GenericClassToFindTheMax<int>(val1, val2, val3);
            GenericClassToFindTheMax<float> floatObj = new GenericClassToFindTheMax<float>(val4, val5, val6);
            GenericClassToFindTheMax<string> stringObj = new GenericClassToFindTheMax<string>(val7, val8, val9);
            
            //Displaying max value for Integers
            Console.WriteLine("\nThe Maximum value of Integer out of {0}, {1} and {2} is {3}", val1, val2, val3, intergerObj.MaxMethod());
            //Displaying max value for Floats
            Console.WriteLine("\nThe Maximum value of Float out of {0}, {1} and {2} is {3}", val4, val5, val6, floatObj.MaxMethod());
            //Displaying max value for Strings
            Console.WriteLine("\nThe Maximum value of string out of {0}, {1} and {2} is {3}", val7, val8, val9, stringObj.MaxMethod());

        }
    }
}