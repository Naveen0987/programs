using System;
using System.Collections.Generic;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }

            numMap[nums[i]] = i;
        }

        return new int[] { };
    }
}

class Program
{
    static void Main(string[] args)
    {
        TwoSumSolution solution = new TwoSumSolution();
        
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        
        int[] result = solution.TwoSum(nums, target);
        
        if (result.Length == 2)
        {
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
            Console.WriteLine($"Values: [{nums[result[0]]}, {nums[result[1]]}]");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
