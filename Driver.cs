using System;

namespace ProductivityTracker
{
    class Driver
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter initial category");
            
            Dashboard f = new Dashboard(Console.ReadLine());
            bool done = false;
            string catIn;
            string userIn;
            while (!done)
            {
                Console.WriteLine("Curr options");
                Console.WriteLine("1. See Dashboard");
                Console.WriteLine("2. See current timing");
                Console.WriteLine("3. Add a new category");
                Console.WriteLine("4. Add and switch to new category");
                Console.WriteLine("5. Switch categories");
                Console.WriteLine("6. Quit");
                userIn = Console.ReadLine();
                if (userIn == "1" || userIn == "See Dashboard")
                {
                    f.displayDashboard();
                }
                else if (userIn == "2" || userIn == "See current timing")
                {
                    f.displayCurrTimeElapsed();
                }
                else if (userIn == "3" || userIn == "Add a new category")
                {
                    Console.Write("Please enter a new category: ");
                    catIn = Console.ReadLine();
                    f.addCat(catIn);
                    Console.WriteLine();
                }
                else if (userIn == "4" || userIn == "Add and switch to new category")
                {
                    Console.Write("Please enter a new category: ");
                    catIn = Console.ReadLine();
                    f.addCat(catIn);
                    Console.WriteLine();
                    f.switchCat(catIn);
                }
                else if (userIn == "5" || userIn == "Switch categories")
                {
                    Console.Write("Enter the category to switch to:");
                    catIn = Console.ReadLine();
                    f.switchCat(catIn);
                }
                else if (userIn == "6" || userIn == "Quit")
                    done = true;
                else
                    Console.WriteLine("Invalid input");
            }
        }
    }
}
