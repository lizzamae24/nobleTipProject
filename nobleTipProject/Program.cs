public class Program
{
    public static void Main(string[] args)
    {
        double totalBill;
        double liquorCharge;
        double tipPercentage;
        double tip;

        Console.Write("Enter total bill: ");
        totalBill = double.Parse(Console.ReadLine());

        Console.Write("Enter liquor charge: ");
        liquorCharge = double.Parse(Console.ReadLine());

        Console.Write("Enter tip percentage: ");
        tipPercentage = double.Parse(Console.ReadLine());

        tip = (totalBill - liquorCharge) * tipPercentage;

        Console.WriteLine($"Tip: {tip}");
    }
}