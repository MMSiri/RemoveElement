internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
    }
}

public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == val) continue;
                    else { nums[i] = nums[j]; nums[j] = val; }
                    j = nums.Length;
                }
            }
            else continue;
        }

        int numsLength = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) numsLength--;
        }

        return numsLength;
    }
}