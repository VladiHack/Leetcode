public class Program
{
    public static void Main(string[] args)
    {
        string roman=Console.ReadLine();
        Console.WriteLine(RomanToInt(roman));
    }

    public static int RomanToInt(string roman)
    {
        int convertedToInt = 0;

        Dictionary<char,int> romanValues=new Dictionary<char,int>();

        romanValues.Add('I', 1);
        romanValues.Add('V', 5);
        romanValues.Add('X', 10);
        romanValues.Add('L', 50);
        romanValues.Add('C', 100);
        romanValues.Add('D', 500);
        romanValues.Add('M', 1000);

        char biggestNum = 'I';

        for(int i=roman.Length-1;i>=0;i--)
        {
            char currentNum=roman[i];
            if (romanValues[currentNum] < romanValues[biggestNum])
            {
                convertedToInt-=romanValues[currentNum];
            }
            else
            {
                convertedToInt += romanValues[currentNum];
                biggestNum = currentNum;
            }
        }


        return convertedToInt;
    }
}