using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sum = { 1, 9, 4,5 };
           var p = ArraySum(sum);
            Console.Write("\n Sum Array {0} ", p);
           var q= DescArray(sum);
            Console.Write("\n Desc Array {0} ", q);
        }

        //Determine if any two integers in array sum to given integer

        public static string ArraySum(int[] sumArray)
        {
            var sumList = new List<int>();

            for (int i = 0; i < sumArray.Length; i++)
            {
                for (int j = i + 1; j < sumArray.Length; j++)
                {
                    if (sumArray[i] != sumArray[j])
                    {
                        sumList.Add(sumArray[i] + sumArray[j]);
                    }

                }
            }
            
            return string.Join(",", sumList.ToArray()); 
        }

        //Sort an array in descending order
        public static string DescArray(int [] sum)
        {
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = sum.Length-1;  i < j; j--)
                {
                    if(sum[i] < sum[j])
                    {
                        int temp = sum[i];
                        sum[i] = sum[j];
                        sum[j] = temp;
                    }
                }
            }

            return string.Join(",", sum);
        }
        


    }
}
