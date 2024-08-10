namespace NTo1;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int number = n;
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(n);
            n = n - 1;
        }
    }
}