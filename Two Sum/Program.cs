using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 4, 11, 3];
            int target = 6;

            TwoSum(nums,target);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] Numeros = new int[2];

            for(int i = 0;i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Numeros[0] = j;
                        Numeros[1] = i;
                        return Numeros;
                    }
                }
            }

            return Numeros;
        }
    }
}
