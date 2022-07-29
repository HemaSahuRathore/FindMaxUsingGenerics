using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblemUsingGenerics
{
    public class GenericClassToFindTheMax<T> where T : IComparable
    {
        public T val1, val2, val3;

        public GenericClassToFindTheMax(T val1, T val2, T val3)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
        }

        //Generic Method to find Max Value
        public static T FindTheMaxValue(T val1, T val2, T val3)
        {
            if ((val1.CompareTo(val2) >= 0) && (val1.CompareTo(val3) >= 0))
                return val1;
            else if ((val2.CompareTo(val1) >= 0) && (val2.CompareTo(val3) >= 0))
                return val2;
            else if ((val3.CompareTo(val1) >= 0) && (val3.CompareTo(val2) >= 0))
                return val3;
            else
                return default;  //return based on the data type
        }

        public T MaxMethod()
        {
            T max = GenericClassToFindTheMax<T>.FindTheMaxValue(this.val1, this.val2, this.val3);  
            return max;
        }
   
    }
}
