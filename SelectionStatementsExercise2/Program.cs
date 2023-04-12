namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So what was your favorite subject in school?");
            
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Gross! That's the worst!");
                    break;
            }
            switch (subject.ToLower())
            {
                case "science":
                    Console.WriteLine("Ah, yes yes. A fine selection.");
                    break;
            }
            switch (subject.ToLower())
            {
                case "writing":
                    Console.WriteLine("Objectively the best choice!");
                    break;
            }
            switch (subject.ToLower())
            {
                case "Art":
                    Console.WriteLine("Could be better could be worse, if finger painting is \n" +
                        "involved then count me in!");
                    break;
            }
                        switch (subject.ToLower())
            {
                default:
                    Console.WriteLine("Sorry... I wish lunch or gym counted too.. :(");
                    break;
            }
        }
    }
}