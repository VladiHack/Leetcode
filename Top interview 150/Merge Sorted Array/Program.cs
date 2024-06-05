public class Program
{
    public static void Main(string[] args)
    {
        int[] nums1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] nums2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int m=nums1.Length;
        int n=nums2.Length;
        Merge(nums1, m-n, nums2, n);
        Console.WriteLine(String.Join(",",nums1));
    }
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
       for(int i=m;i<m+n;i++)
        {
            nums1[i] = nums2[i - m];
        }
        Array.Sort(nums1);
    }
}