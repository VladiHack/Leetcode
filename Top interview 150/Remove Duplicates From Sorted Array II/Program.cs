public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        RemoveDuplicates(nums);
        Console.WriteLine(String.Join(",",nums));
    }
    public static int RemoveDuplicates(int[] nums)
    {
        const int max = int.MaxValue;
        int remaining = 0; int currentNum = max; bool repeated = false;
        for(int i=0;i<nums.Length; i++)
        {
            if (nums[i] == currentNum)
            {
                if (repeated)
                {
                    nums[i] = max;
                }
                else
                {
                    remaining++;
                    repeated = true;
                }
            }
            else
            {
                currentNum = nums[i];
                remaining++;
                repeated = false;
            }
        }
        int lastK = -1;
        for (int i = 0; i < remaining; i++)
        {
            if (nums[i]==max)
            {
                if (lastK == -1)
                {
                    for (int k = i + 1; k < nums.Length; k++)
                    {
                        if (nums[k] != max)
                        {
                            int temp = nums[k];
                            nums[k] = nums[i];
                            nums[i] = temp;
                            break;
                        }
                    }
                }
                else
                {
                    for (int k = lastK; k < nums.Length; k++)
                    {
                        if (nums[k] != max)
                        {
                            int temp = nums[k];
                            nums[k] = nums[i];
                            nums[i] = temp;
                            break;
                        }
                    }
                }
                        
            }
        }
        return remaining;
    }
}