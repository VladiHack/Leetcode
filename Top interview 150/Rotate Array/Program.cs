public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        Rotate(arr,k);
        Console.WriteLine(string.Join(" ",arr));
    }
    public static void Rotate(int[] nums, int k)
    {
        int[] arr = new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            if(i+k>=nums.Length)
            {
                arr[(i+k)%nums.Length]= nums[i];
            }
            else
            {
                arr[i + k] = nums[i];
            }
        }
        for(int i=0;i<arr.Length;i++)
        {
            nums[i] = arr[i];
        }
    }
}