namespace EvenPowersOf2;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        for (int i = 0; i <= n; i += 2)
        {
            int result = (int)Math.Pow(2, i);
            Console.WriteLine(result);
        }
    }
}