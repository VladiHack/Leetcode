public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(MajorityElement(arr));
    }
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int,int> timesMet=new Dictionary<int,int>();
        int mostTimesMet = 0;
        int mostMetNum = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if (!timesMet.ContainsKey(nums[i]))
            {
                timesMet.Add(nums[i],0);
            }
            timesMet[nums[i]]++;
            if (timesMet[nums[i]] > mostTimesMet)
            {
                mostTimesMet = timesMet[nums[i]];
                mostMetNum = nums[i];
            }
        }
        return mostMetNum;
    }
}