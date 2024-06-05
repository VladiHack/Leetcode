public class Program
{
    public static void Main(string[] args)
    {
        int[] nums=Console.ReadLine().Split().Select(int.Parse).ToArray();
        RemoveDuplicates(nums);
        Console.WriteLine(String.Join(",",nums));
    }
    public static int RemoveDuplicates( int[] nums)
    {
        int[] arr = new int[nums.Length];int index = 0;
        if(nums.Length> 0)
        {
            arr[index] = nums[index];
            index++;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i-1])
                {
                    arr[index] = nums[i];
                    index++;
                }
            }
            for(int i=0; i < index; i++)
            {
                nums[i] = arr[i];
            }
        }
        
        return index;
    }
}