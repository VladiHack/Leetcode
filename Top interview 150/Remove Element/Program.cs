public class Program
{
    public static void Main(string[] args)
    {
        int[] nums=Console.ReadLine().Split().Select(int.Parse).ToArray();
        int val = int.Parse(Console.ReadLine());
        Console.WriteLine(RemoveElement(nums, val));
        Console.WriteLine(String.Join(",",nums));
    }
    public static int RemoveElement(int[] nums, int val)
    {
        int countDifferent = 0;
        List<int> emptyIndexes = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                emptyIndexes.Add(i);
            }
            else
            {
                countDifferent++;
                if (emptyIndexes.Count() != 0)
                {
                    nums[emptyIndexes[0]] = nums[i];
                    nums[i] = 0;
                    emptyIndexes.RemoveAt(0);
                    emptyIndexes.Add(i);
                }
            }
        }
        return countDifferent;
    }
}