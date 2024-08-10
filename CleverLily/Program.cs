namespace CleverLily;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int toysPrice = int.Parse(Console.ReadLine());
        
        int count = 0;
        int moneySaved = 0;
        int moneyYearly = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i%2==0)
            {
                
                moneySaved += 10;
                moneyYearly += moneySaved - 1;
            }
            else
            {
                count++;
            }
        }

        double toys = toysPrice * count;

        double lillyMoney = moneyYearly + toys;
        
        if (lillyMoney>=washingMachinePrice)
        {
            Console.WriteLine("Yes! " + (lillyMoney-washingMachinePrice).ToString("f2"));
        }
        else
        {
            Console.WriteLine("No! "+ (washingMachinePrice-lillyMoney).ToString("f2"));
        }
    }
}