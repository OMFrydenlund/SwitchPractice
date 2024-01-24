namespace SwitchPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindDay();
        }

        private static void FindDay()
        {   
            Console.Clear();
            Console.WriteLine("What day of the week do you want to find? ");
            var userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Monday is the 1st day.");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Tuesday is the 2nd day.");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Wednesday is the 3rd day.");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Thursday is the 4th day.");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Friday is the 5th day.");
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Saturday is the 6th day.");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Sunday is the 7th day.");
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("There's only seven days in a week friend. Let's try again..");
                    Console.ReadKey();
                    FindDay();
                    break;
            }
        }
    }
}
