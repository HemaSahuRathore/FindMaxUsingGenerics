namespace FindMaxProblemUsingGenerics
{ /// <summary>
  /// UC5 : Extend the max method to also print the max to std out using Generic Method
  /// </summary>
    internal class Program
    {
        //An entrypoint of main program
        static void Main(string[] args)
        {
            //Arrays
            int[] intArray = { 85, 96, 25, 79, 36 };
            float[] floatArray = { 85.35f, 78.85f, 95.78f, 48.35f, 84.74f };
            string[] stringArray = { "Custard Apple", "Peach", "Banana", "Mango", "Dragon Fruit" };

            //Object Creation
            GenericClassToFindTheMax<int> intergerObj = new GenericClassToFindTheMax<int>(intArray);
            GenericClassToFindTheMax<float> floatArrayObj = new GenericClassToFindTheMax<float>(floatArray);
            GenericClassToFindTheMax<string> stringObj = new GenericClassToFindTheMax<string>(stringArray);
            
            //Printing maximum value
            intergerObj.PrintMaxMethod();
            floatArrayObj.PrintMaxMethod();
            stringObj.PrintMaxMethod();




        }
    }
}