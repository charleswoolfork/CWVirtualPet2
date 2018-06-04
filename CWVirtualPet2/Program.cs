using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //This part allows the user to give their name and to name their pet while assigning random numbers to fields.
            Random random = new Random();
            int Hunger = random.Next(90, 100);
            int Thirst = random.Next(50, 70);
            int Bathroom = random.Next(40, 80);
            int Energy = random.Next(50, 80);
            int Affection = random.Next(65, 100);

            //PROPERTIES
            VirtualPet userPup = new VirtualPet();
            userPup.Hunger = Hunger;
            userPup.Thirst = Thirst;
            userPup.BathroomNeed = Bathroom;
            userPup.Energy = Energy;
            userPup.Affection = Affection;

            //UI
            Console.WriteLine("Welcome to the Virtual Pet Application!\n Please tell me your name.");
            string ownersName = Console.ReadLine();
            userPup.OwnersName = ownersName;
            Console.Clear();
            Console.WriteLine("What would you like to name your pet?");
            userPup.PetsName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Congratulations {0}!\nYou now have {1} a virtual puppy!", userPup.OwnersName, userPup.PetsName);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();


            //This section does work until the puppy reaches a happines level of at least 90. Then user can quit at anytime.
            do
            {

                userPup.GetStatus(); // "TICK"

                //USER MENU
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\tPress 1 to feed {0}.", userPup.PetsName);
                Console.WriteLine("\tPress 2 to give {0} water.", userPup.PetsName);
                Console.WriteLine("\tPress 3 to take {0} outside to go to the bathroom.", userPup.PetsName);
                Console.WriteLine("\tPress 4 to rub {0}'s belly.", userPup.PetsName);
                Console.WriteLine("\tPress 5 to play with {0}.", userPup.PetsName);
                Console.WriteLine("\tPress 6 to quit the game.");
                int userChoice = int.Parse(Console.ReadLine());

                while (userChoice < 1 || userChoice > 6)
                {
                    Console.WriteLine("You must choose 1 - 6 from the menu!\nWhat do you want to do for your puppy?");
                    userChoice = int.Parse(Console.ReadLine());
                }


                switch (userChoice)
                {

                    case 1:
                        {
                            userPup.FeedPuppy();
                        }
                        break;

                    case 2:
                        {
                            userPup.WaterPuppy();
                        }
                        break;

                    case 3:
                        {
                            userPup.Bathroom();
                        }
                        break;

                    case 4:
                        {
                            userPup.RubPuppy();
                        }
                        break;

                    case 5:
                        {
                            userPup.PlayWithPuppy();
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("{0} says, \"What a lazy owner!\"", userPup.PetsName);
                            Console.WriteLine("Your puppy is now a stray");
                            Environment.Exit(0);
                        }
                        break;

                    default: //the while loop above controls this, default is an extra safe guard that will simply feed the puppy. 
                        {
                            Console.WriteLine("{0)} says, \"Thank you for the food!\"", userPup.PetsName);
                            userPup.FeedPuppy();
                            break;
                        }


                }
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();


            } while (userPup.PetHappiness <= 75);

            //this section is what prints to the console when the virtual puppy's satisfaction is greater than  or equal to 75).

            Console.WriteLine("\nCongratulations {0}!\nYou have made {1} very happy today!\nThanks for playing Virtual Puppy!", userPup.OwnersName, userPup.PetsName);

        }//MAIN

    }//CLASS

}//NAMESPACE