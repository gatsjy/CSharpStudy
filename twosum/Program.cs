using System;
using System.Linq;

namespace twosum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Array.Sort(nums);
            int[] result = { };
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result = new int[] { i, j };
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] input = { 2, 7, 11, 15 };
            TwoSum(input, 9);
        }
    }
}
