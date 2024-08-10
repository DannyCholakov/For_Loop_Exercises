namespace LeftAndRightSum;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int summOne=0;
        int summTwo=0;
        for (int i = 1; i <= n*2; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i<=n)
            {
                summOne += number;
            }
            else
            {
                summTwo += number;
            }
        }

        if (summOne==summTwo)
        {
            Console.WriteLine("Yes, sum = " + summOne);
        }
        else if(summOne>summTwo)
        {
            Console.WriteLine("No, diff = "+(summOne-summTwo));
        }
        else
        {
            Console.WriteLine("No, diff = "+(summTwo-summOne));
        }
    }
}