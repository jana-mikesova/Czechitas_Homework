namespace L2_riddler
{
    //Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší
    //a umožní hádat tak dlouho, dokud se uživatel netrefí:
    //Např.
    //Hádej číslo: 10
    //  Číslo je menší, hádej znovu: 5
    //   Číslo je větší, hádej znovu: 7
    //   To je správně!

    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = 10;
            bool guessed = false;
            
            Console.WriteLine("Hádej celé číslo:");

            while (!guessed)
            {
                int guessedNumber = getNumber(Console.ReadLine());
                guessed = compareNumber(guessedNumber, enteredNumber);
                
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

        public static bool compareNumber(int tipNum, int realNum)
        {
            if (tipNum == realNum)
            {
                Console.WriteLine("To je správně!");
                return true;
            }
            else if (tipNum > realNum)
            {
                Console.WriteLine("Číslo je větší, hádej znovu:");
                return false;
            }
            else
            {
                Console.WriteLine("Číslo je menší, hádej znovu:");
                return false;
            }
        }
    }
}
