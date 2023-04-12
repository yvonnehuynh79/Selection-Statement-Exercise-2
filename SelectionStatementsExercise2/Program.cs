namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" what is your favorite school subject?");
            string answer = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "math":
                    Console.WriteLine("me too");
                    break;
                case "nail class":
                    Console.WriteLine("oh you can see me for that");
                    break;
                case "history":
                    Console.WriteLine(" I'm not good with that");
                    break;
                case "science":
                    Console.WriteLine("Interesting!");
                    break;
                case "pe":
                    Console.WriteLine("i don't like it");
                    break;
                default:
                    Console.WriteLine("ooh ok");
                    break;

            }
        }
    }
}