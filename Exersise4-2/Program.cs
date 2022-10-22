namespace Exersise4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dic1 = new Dice();
            Dice dic2 = new Dice();
            SnakeEyes(dic1, dic2);
        }

        static void SnakeEyes(Dice dice1, Dice dice2)
        {
            int mark1 = 0, mark2 = 0, i = 1;
            while (!(mark1 == 1 && mark2 == 1))
            {
                mark1 = dice1.Throw();
                mark2 = dice2.Throw();
                Console.WriteLine(" {0} Mark of Dices : {1},{2} ", i, mark1, mark2);
                System.Threading.Thread.Sleep(10);
                i = i + 1;
            }
            Console.WriteLine("Throw of both dices = 1 is : " + (i - 1) + " time ");
            Console.ReadLine();
        }
    }
}