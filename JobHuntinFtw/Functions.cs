using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHuntinFtw
{
    class Functions
    {

        public static void AppStart()
        {
            Console.WriteLine("Hello, Welcome to PostHaste Hiring Solutions!");
            Console.WriteLine("Our questions are so direct, you'll be sure to hit a Bullseye EVERYTIME!");

        }

        public static void UserStart(User user)
        {
        

            Console.WriteLine("What is your first name?");
            user.FirstName = Console.ReadLine();
            Console.Beep(500, 700);
            Console.Beep(500, 700);
            Console.Beep(500, 700);
           
            Console.WriteLine("Great! Hello " + user.FirstName);
            Console.WriteLine("Before we get started, what Company are you with?");
            user.CompanyName = Console.ReadLine();
            Console.Beep(500, 700);
            Console.Beep(500, 700);
            Console.Beep(500, 700);
            Console.WriteLine("Welcome, " + user.FirstName + " with " + user.CompanyName);
            Console.WriteLine("We'll get right on to finding your next hiree, PostHaste!");
            Console.Beep(500, 700);
            Console.Beep(500, 700);
            Console.WriteLine("Accessing...");
            Console.Beep(300, 3000);
            Console.WriteLine("ACCESS GRANTED");
            Console.ReadLine();

        }

        public static void Questions(User user)
        {
           

            Console.WriteLine("Are you looking for someone who cares deeply about the quality of their code?");
            var userResponse = Console.ReadLine();


            if ((userResponse == "YES") || (userResponse == "Yes") || (userResponse == "yes"))
            {
                Console.WriteLine("Great, Let's move on, " + user.FirstName + " !");
                Console.ReadKey();
            }
            else if ((userResponse == "Maybe") || (userResponse == "maybe") || (userResponse == "MAYBE"))
            {
                Console.WriteLine("You seem, unsure. No worries, we aren't finished yet " + user.FirstName + " !");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Answer is invalid, please answer with a Yes or No. I'm not Siri, " + user.FirstName + "!");
                Console.ReadKey();
            }

            Console.ReadLine();
        }
    }
}
