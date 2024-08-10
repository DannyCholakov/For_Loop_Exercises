namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            
            int peopleOnHike = 0;
            int musalaCount = 0;
            int monblanCount = 0;
            int kilimandjaroCount = 0;
            int k2Count = 0;
            int everestCount = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                peopleOnHike += peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    musalaCount += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    monblanCount += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    kilimandjaroCount += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    k2Count += peopleInGroup;
                }
                else
                {
                    everestCount += peopleInGroup;
                }
            }
            
            double musalaProcent = (musalaCount / (double)peopleOnHike) * 100;
            double monblanProcent = (monblanCount / (double)peopleOnHike) * 100;
            double kilimandjaroProcent = (kilimandjaroCount / (double)peopleOnHike) * 100;
            double k2Procent = (k2Count / (double)peopleOnHike) * 100;
            double everestProcent = (everestCount / (double)peopleOnHike) * 100;
            
            Console.WriteLine($"{musalaProcent:f2}%");
            Console.WriteLine($"{monblanProcent:f2}%");
            Console.WriteLine($"{kilimandjaroProcent:f2}%");
            Console.WriteLine($"{k2Procent:f2}%");
            Console.WriteLine($"{everestProcent:f2}%");
        }
    }
}
