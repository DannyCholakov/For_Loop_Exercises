namespace TennisRanklist;

class Program
{
    static void Main(string[] args)
    {
        int tornaments = int.Parse(Console.ReadLine());
        int startingPoints = int.Parse(Console.ReadLine());
        int wins = 0;
        int finalPoints=0;
        for (int i = 0; i < tornaments; i++)
        {
            string position = Console.ReadLine();
            switch (position)
            {
                case "W": wins++; finalPoints += 2000; break;
                case "F": finalPoints += 1200; break;
                case "SF": finalPoints += 720; break;
            }
        }

        Console.WriteLine($"Final points: {finalPoints+startingPoints}");
        Console.WriteLine($"Average points: {finalPoints/tornaments}");
        Console.WriteLine(((wins/(double)tornaments)*100).ToString("f2")+"%");
    }
}