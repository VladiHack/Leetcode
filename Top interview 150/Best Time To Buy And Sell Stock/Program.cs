public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(MaxProfit(arr));
    }
    public static int MaxProfit(int[] prices)
    {
        int profit = 0;int smallestByFar = int.MaxValue;
        for(int i = 0; i < prices.Length-1; i++)
        {
            if (prices[i] >= prices[i+1])
            {
                continue;
            }
            if (prices[i]<smallestByFar)
            {
                smallestByFar = prices[i];
                for(int j=i+1;j<prices.Length;j++)
                {
                    if (prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
        }
        return profit;
    }
}

