namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pup = "Shadow"; //This is all for a dog
            int age = 1;
            char bestLetter = 'T';
            bool amTired = true; 
            double pi = 3.14;
            decimal alot = 4815162342m;
            Console.WriteLine($"My dog's name is {pup}, he is {age} years old.");
            Console.WriteLine($"It is {amTired} {bestLetter} is the first letter of my name.");
            Console.WriteLine($"The two numbers I think about the most are {pi} and {alot}.");
        }
    }
}
