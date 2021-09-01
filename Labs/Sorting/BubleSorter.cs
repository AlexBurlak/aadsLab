using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Sorting
{
    public class BubleSorter
    {
        public static void Sort(ref int[] inputData, out string sortStamp)
        {
            sortStamp = "";
            short flag = 0;
            int n = inputData.Length;
            for (int i = 0; i < n; ++i)
            {
                flag = 0;
                for (int j = 0; j < n - 1 - i; ++j)
                {
                    if (inputData[j] > inputData[j+1])
                    {
                        flag = 1;
                        int temp = inputData[j];
                        inputData[j] = inputData[j+1];
                        inputData[j+1] = temp;
                    }
                }
                sortStamp += string.Join("; ", inputData) + ";\n";
                if (flag == 0) break;
            }
        }
    }
}
