using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenerics
{
    internal class MaximumNumberCheck<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public MaximumNumberCheck(T firstValue, T secondValue, T thirdValue)
        {
            // this is a constructor in which we are init the instance variable
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;


        }
        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }

            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }

            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }

            return default;

        }


        public T MaxMethod()
        {
            //Calling MaxValue Method internally from this method
            T max = MaximumNumberCheck<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }

    }
}
