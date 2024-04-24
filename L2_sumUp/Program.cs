namespace L2_sumUp
{
    //Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první číslo:");
            double firstNumber = getNumber(Console.ReadLine());

            Console.WriteLine("Zadejte druhé číslo:");
            double secondNumber = getNumber(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }

        public static double getNumber(string String)
        {
            bool isNumber = false;
            double result = 0;
            
            while (!isNumber)
            {
                isNumber = double.TryParse(String, out result);
                if (!isNumber)
                {
                    Console.WriteLine("Nebylo zadáno číslo, zadej znovu:");
                    String = Console.ReadLine();
                }
            }
            return result;
        }
    }
}
