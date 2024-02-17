using System;

class Program
{

    static void Main(string[] args)
    {
       
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity"); 
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);


            if (choice == 1)
            {
               string name = "Breathing Activity";
               string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

               BreathingActivity newBreathingActivity = new BreathingActivity(name, description);
               newBreathingActivity.Run();

            }

            else if (choice == 2)
            {
               string name = "Reflecting Activity";
               string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

               //This section is the runing of the Reflecting Activity
               ReflectingActivity newReflectingActivity = new ReflectingActivity(name, description);
               newReflectingActivity.Run();
          
            }

            else if (choice == 3)
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                //This section is the runing of the Listing Activity
               ListingActivity newListingActivity = new ListingActivity(name, description);
               newListingActivity.Run(); 
            }

            else if (choice == 4)
            {
                break;
            }   
        }
    }
}