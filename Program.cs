namespace Mutli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number_One, number_Two;
            int ans_MultiDigits;

            Console.WriteLine("Enter value Number One:");
            number_One = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value Number Two:");
            number_Two = int.Parse(Console.ReadLine());

            ans_MultiDigits = number_One * number_Two;

            Console.WriteLine("Multi number {0} and number {1} :  {2}", number_One, number_Two, ans_MultiDigits);
        }
    }
}