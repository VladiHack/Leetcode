public class Program
{
    public static void Main(string[] args)
    {
        int[] citations=Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(HIndex(citations));
    }
    public static int HIndex(int[] citations)
    {
        int n = citations.Length;
        Array.Sort(citations);
        for (int i = 0; i < n; i++)
        {
            if (citations[i] >= n - i) return n - i;
        }
        return 0;
    }
}