namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i <= 7; i++) 
            {
                Console.WriteLine(diffCurrencies(i));            
            }
        }
        static string diffCurrencies(int i)
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };
            return currencies[i];
        }
    }
}
