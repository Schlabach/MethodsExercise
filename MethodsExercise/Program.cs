namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.WriteLine("Hello, we are going to play a fun game of MadLibs, but I will need some input from you. First what is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine($"Hi {yourName}, what is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine($"Good choice, {favoriteColor} is a great color!");

            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

                if(favoriteAnimal == "penguin")
                {
                    Console.WriteLine("No way, that's mine too!");
                }
                else
                {
                    Console.WriteLine($"Penguins are better, but I guess {favoriteAnimal}s are ok.");
                }

            Console.WriteLine("The last thing I need to know is what is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"Alright {yourName}, this is a good one: The {favoriteAnimal} is the most impressive animal in the world. Not only can they fly, but they can camouflage due to being {favoriteColor}. Seeing one in real life is like being front row at a {favoriteBand} concert.");
            
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: (sum)");

            Console.WriteLine("Give me a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The sum is: (product)");
        }
        public static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
        
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}