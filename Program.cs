namespace Topic_8___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Cypher" };
            Console.WriteLine(names[1] + " is 'The One'.");
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.WriteLine("There are " + names.Count + " names in my List.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + " is the bad guy.");
            Console.ReadLine(); // Keeps program from closing
            //The number in square brackets is the value assigned to a thing in the list
            //Console.WriteLine(names[0]);
            //what
            //names.Count is the number of things in the list

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }
            //loops help print everything quicker because it's a pain to write out each individual "Console.Wrrteline"
            //i hate lists this is stupid

            List<int> numbers = new List<int>(); // Creates an empty List
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.ReadLine(); // Keeps the program from ending
        }
    }
}
