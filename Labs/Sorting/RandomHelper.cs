using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Sorting
{
    public class RandomHelper
    {
        private Random _random;
        private int[] _previousArray;
        public RandomHelper()
        {
            _random = new Random((int)DateTime.Now.Ticks);
        }

        public int[] GenerateArray(int arraySize)
        {
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; ++i)
            {
                array[i] = _random.Next(-100, 100);
            }
            _previousArray = array;
            return array;
        }
        public int[] PreviousArray {
            get
            {
                if(_previousArray == null) { throw new NullReferenceException(); }
                return _previousArray;
            } 
        }
    }
}
