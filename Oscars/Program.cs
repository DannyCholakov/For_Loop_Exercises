namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double initialPoints = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());
            double totalPoints = initialPoints;
            
            for (int i = 0; i < juryCount; i++)
            {
                string juryName = Console.ReadLine();
                double pointsFromJury = double.Parse(Console.ReadLine());
                
               
                totalPoints += (juryName.Length * pointsFromJury) / 2;

              
                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }

            
            Console.WriteLine($"Sorry, {actor} you need {(1250.5 - totalPoints):f1} more!");
        }
    }
}