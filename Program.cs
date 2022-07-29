namespace FindMaxProblemUsingGenerics
{ /// <summary>
  /// UC4 : Extend the max method to take more then three parameters 
  /// -Use Options and use Sorting
  /// </summary>
    internal class Program
    {
        //An entrypoint of main program
        static void Main(string[] args)
        {
            ////Integers array
            int[] intArray = { 85, 96, 25, 79, 36 };
            GenericClassToFindTheMax<int> intergerObj = new GenericClassToFindTheMax<int>(intArray);

            //Float variables
            float[] floatArray = { 85.35f, 78.85f, 95.78f, 48.35f, 84.74f };
            GenericClassToFindTheMax<float> floatArrayObj = new GenericClassToFindTheMax<float>(floatArray);

            ////String variables
            string[] stringArray = { "Custard Apple", "Peach", "Banana", "Mango", "Dragon Fruit" };
            GenericClassToFindTheMax<string> stringObj = new GenericClassToFindTheMax<string>(stringArray);

            //Displaying max value for Integers
            Console.WriteLine("\nThe Maximum value of Integer: " + intergerObj.MaxMethod());
            //Displaying max value for Floats
            Console.WriteLine("\nThe Maximum value of Integer: " + floatArrayObj.MaxMethod());
            //Displaying max value for Strings
            Console.WriteLine("\nThe Maximum value of Strings : " + stringObj.MaxMethod());
           

        }
    }
}