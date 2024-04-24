namespace L2_stars
{
    //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet hvězdiček k zobrazení:");
            int numOfStars = getNumber(Console.ReadLine());

            for (int i = 0; i < numOfStars; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numOfStars; i++)
            {
                for (int j = numOfStars; i+1 < j; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static int getNumber(string String)
        {
            bool isNumber = false;
            int result = 0;

            while (!isNumber)
            {
                isNumber = int.TryParse(String, out result);
                if (!isNumber)
                {
                    Console.WriteLine("Nebylo zadáno celé číslo, zadej znovu:");
                    String = Console.ReadLine();
                }
            }
            return result;
        }
    }
}
