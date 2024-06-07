public class Program
{
    public static void Main(string[] args)
    {
        int[] gas = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] cost=Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(CanCompleteCircuit(gas,cost));
    }
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int index = -1;
        int[] prices=new int[gas.Length];
        for(int i=0;i<gas.Length;i++)
        {
            prices[i] = gas[i] - cost[i];
        }
        for (int i=0;i<gas.Length;i++)
        {
            int sum = 0;
            if (prices[i]>=0)
            { 
                sum = 0;
                for(int s=i;s<gas.Length;s++)
                {
                    sum += prices[s];
                    if(sum<0)
                    {
                        i = s;
                        break;
                    }
                }
                if (sum < 0) continue;
                for(int s=0;s<i;s++)
                {
                    sum += prices[s];
                    if(sum<0)
                    {
                        break;
                    }
                }
                if(sum>=0)
                {
                    return i;
                }
            }
        }
        return index;
    }
   
}