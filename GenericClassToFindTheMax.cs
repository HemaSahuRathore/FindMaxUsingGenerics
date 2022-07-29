using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblemUsingGenerics
{
    public class GenericClassToFindTheMax<T> where T : IComparable
    {
        public T[] value;

        //Constructor to assign the Instance Variable
        public GenericClassToFindTheMax(T[] value)
        {
            this.value = value;
        }

        //Method to sort array
        public T[] SortArray(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        
        //Method to find Max Value
        public T MaxValue(params T[] values) //using param keyword to extend the Maxvalue method to take more than 3 Parameters
        {
            var sortedValues = SortArray(values);
            return sortedValues[sortedValues.Length - 1];
        }

        //Method to Print the Maximum value
        public void PrintMaxMethod()
        {
            T max = MaxValue(this.value);
            Console.WriteLine("\nThe Maximum value of Integer: " + max); 
        }
   
    }
}
