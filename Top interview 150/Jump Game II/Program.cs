using System.Runtime.Intrinsics.Arm;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(Jump(arr));
    }
    public static int Jump(int[] nums)
    {
            int leastJumps = int.MaxValue;
            int[] minimalJumps= new int[nums.Length];
            for(int i=0;i<nums.Length; i++)
            {
                if (minimalJumps[i]!=0 || i == 0 )
                {
                    for(int k = 1; k <= nums[i];k++)
                    {
                        if(i+k>=nums.Length)
                        { break; }
                        if (minimalJumps[i+k]!=0)
                        {
                            minimalJumps[i+k] = Math.Min(minimalJumps[i+k], minimalJumps[i] + 1);
                        }
                        else
                        {
                            minimalJumps[i+k] = minimalJumps[i] + 1;
                        }
                    }
                }
            }
            return minimalJumps[minimalJumps.Length-1];
    }
}