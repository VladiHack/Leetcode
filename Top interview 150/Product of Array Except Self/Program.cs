public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(String.Join(",",ProductExceptSelf(nums)));

    }
    public static int[] ProductExceptSelf(int[] nums)
    {
        int product = 1;int timesHasZero = 0;
        for(int i=0;i<nums.Length; i++)
        {
            if (nums[i]==0&&timesHasZero==0)
            {
                timesHasZero++;
            }
            else
            {
                product *= nums[i];
            }
        }
        for(int i=0;i<nums.Length;i++)
        {
            if(timesHasZero==2)
            {
                nums[i] = 0;
            }
            else if (nums[i]==0)
            {
                nums[i] = product;
            }
            else if(timesHasZero==0)
            {
                nums[i] = product / nums[i];
            }
            else
            {
                nums[i] = 0;
            }
        }
        return nums;
    }
}