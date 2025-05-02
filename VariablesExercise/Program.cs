namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Fred";
            int fredAge = 18;
            char lastInitial = 'M';
            bool fredBirthday = true;
            double fredProgress = 100.00;
            decimal fredProgress2 = 30.00m;

            Console.WriteLine(
                $"It is {fredBirthday}, {firstName} {lastInitial}. turns {fredAge} today. He is {fredProgress2}% complete, out of {fredProgress}% on his birthday celebration.");


        }
    }
}
