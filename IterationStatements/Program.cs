namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >- -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Numbers()
        {
            for (int n = 3; n <= 999; n += 3)
            {
                Console.WriteLine(n);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Parameters(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"The two numbers are equal");
            }
            else
            {
                Console.WriteLine("The two numbers are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOdd(int g)
        {
            if (g % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
        }
       
        //Write a method to check whether a given number is positive or negative

        public static void PositiveNegative(int p)
        {
            if (p > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");            
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VoteAge()
        {
            Console.WriteLine("Please enter you age");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are old enough to vote");
                }
                else
                {
                    Console.WriteLine("You are too young to vote");
                }
            }
            else
            {
                Console.WriteLine("You didn't enter you age correctly");
                VoteAge();
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void userInt()
        {
            Console.WriteLine("Please enter a number");

            int.TryParse(Console.ReadLine(), out int userNumber);

            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is in between 10 and -10");
            }

            Console.WriteLine("The number you entered in not in between 10 and -10");
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

         public static void multiplication()
        {
            Console.WriteLine("Please enter a number");

            int.TryParse(Console.ReadLine(), out int number);

            int i = 1;

            do
            { 
                int output = i * number;
                Console.WriteLine(output);
                i++;
            }
            while ( i <= 12);


        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            PrintThousand();

            Numbers();

            Parameters(1,2);

            EvenOdd(7);

            PositiveNegative(-1);

            VoteAge();

            userInt();

            multiplication();

        }
    }
}
