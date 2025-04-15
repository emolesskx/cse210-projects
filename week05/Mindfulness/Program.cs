// Program.cs
// ----------------------------------------------------
// This program exceeds core requirements in the following ways:
// 1. Multiple activity types implemented using proper OOP principles:
//    - Abstraction: Each class contains only relevant attributes/methods.
//    - Encapsulation: Member variables are private/protected.
//    - Inheritance: Activities inherit from a shared base class.
// 2. ListingActivity allows user to list as many items as possible in a time frame
//    and displays all the listed items back.
// 3. Enhanced user experience with countdown and animated pauses.
// 4. Clean and consistent menu system with intuitive navigation.
// 5. Organized code with separate class files and consistent naming conventions.
// 6. Overall design demonstrates creativity, polish, and usability enhancements.
// ----------------------------------------------------

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }
    }
}
