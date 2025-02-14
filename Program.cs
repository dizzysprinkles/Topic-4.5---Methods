namespace Topic_4._5___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Press ENTER for a joke: ");
            //Console.ReadLine();
            //Joke(50);

            int bugs;
            Console.WriteLine("How many bugs are in your code?");
            Int32.TryParse(Console.ReadLine(), out bugs);
            Console.WriteLine();
            Joke(bugs);
            Console.ReadLine();
        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code,");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((++numBugs) + " little bugs in the code.");
        }

        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code,");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");
        }
    }
}
