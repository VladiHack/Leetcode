public class Program
{
    static bool[] visited = new bool[10001]; static bool canJump = false;
    public static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(CanJump(arr));
    }
    public static bool CanJump(int[] nums)
    {
        CheckVariations(nums, 0);
        return visited[nums.Length-1];
    }
    public static void CheckVariations(int[] nums,int index)
    {
        if(visited[index])
        {
            return;
        }
        visited[index] = true;
        for(int i = 1; i <= nums[index];i++)
        {
            if (index + i >= nums.Length)
            {
                break;
            }
            CheckVariations(nums, index + i);
        }
    }
}
