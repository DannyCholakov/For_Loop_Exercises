namespace VowelsSum;

class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        int summ = 0;
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            switch (letter)
            {
                case 'a': summ += 1; break;
                case 'e': summ += 2; break;
                case 'i': summ += 3; break;
                case 'o': summ += 4; break;
                case 'u': summ += 5; break;
            }
        }

        Console.WriteLine(summ);
    }
}