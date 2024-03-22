
namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Challenge";
            Console.WindowHeight = 50;
            Console.WindowWidth = 60;

            MoveScreenClass.ArrowKey();
            Console.ReadKey(true);

        }
    }
}
