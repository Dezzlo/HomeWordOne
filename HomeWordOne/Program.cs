namespace HomeWordOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int value = rnd.Next(0, 100);
            int valueKeyBoard = 0;

            do
            {
                valueKeyBoard = int.Parse(Console.ReadLine());
                if (value > valueKeyBoard)
                {
                    Console.WriteLine("Число больше чем вы написали");
                } else if (value < valueKeyBoard)
                {
                    Console.WriteLine("Число меньше чем вы написали");
                } else
                {
                    Console.WriteLine("Вы угадали число");
                }
            } while (value != valueKeyBoard);

            Console.WriteLine(value);
        }
    }
}