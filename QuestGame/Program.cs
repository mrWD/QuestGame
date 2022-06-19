using System;

namespace QuestGame
{
    class Program
    {
        static int roomNumber = 1;
        static bool hasKey = false;
        static bool hasModule = false;

        static void Main(string[] args)
        {
            Introduction();

            while (true)
            {
                if (roomNumber == 1) ActionStarship();
                else if (roomNumber == 2) ActionTemple();
                else if (roomNumber == 3) ActionLivingRoom();
                else if (roomNumber == 4) ActionDangerRoom();
                else if (roomNumber == 5) ActionQuestRoom();
                else if (roomNumber == 6) ActionOtherShip();
            }
        }

        static void ActionStarship()
        {
            Console.Clear();
            Console.WriteLine("You are inside your C- 6 Starlight.");
            Console.WriteLine("You need fuel and it is obvious that you need to look for it not here.");
            Console.WriteLine("Available actions:");
            Console.WriteLine("1. Get out of the ship.");

            int option;

            if (hasModule)
            {
                Console.WriteLine("2. Get off the planet.");

                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            if (option == 1)
            {
                Console.WriteLine("You leave the ship!");

                roomNumber = 2;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Conclusion();
            }
        }

        static void ActionTemple()
        {
            Console.Clear();
            Console.WriteLine("You are in a spacious stone hall.");
            Console.WriteLine("(*It is rather strange that you fell exactly inside a building)");
            Console.WriteLine("In front of you is a door through which light peeks out.");
            Console.WriteLine("To her right is another door that looks like it hasn't been used in a long time.");
            Console.WriteLine("Available actions:");
            Console.WriteLine("1. Return to the ship");
            Console.WriteLine("2. Enter the door with the light inside");
            Console.WriteLine("3. Go to the door on the right");

            int option = GetIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Return ship!");
                roomNumber = 1;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Нou go to the door with the light and go inside");
                roomNumber = 3;
                Console.ReadLine();
            }
            else
            {
                OpenOldDoor();
            }
        }

        static void OpenOldDoor()
        {
            Console.WriteLine("You approached the door on the right, it seemed to blow cold from it.");
            Console.WriteLine("There is a lock on the door (a triangular keyhole).");

            if (hasKey)
            {
                Console.WriteLine("You try to open the door, but it's in vain, the lock on its handle is obviously against it.");
                Console.WriteLine("it would be nice to find the key to the lock!");
                Console.WriteLine("You may need to check out other areas.");
                Console.WriteLine("You return to the center of the hall.");
            }
            else
            {
                Console.WriteLine("Without thinking twice, you take out the key found earlier.");
                Console.WriteLine("The lock creaks open, you go inside.");

                roomNumber = 4;
            }

            Console.ReadLine();
        }

        static void ActionLivingRoom()
        {
            Console.Clear();
            Console.WriteLine("When you open the door, you find yourself in a small room that looks like a closet.");
            Console.WriteLine("Although there was definitely someone here recently, because the stone fireplace is burning.");
            Console.WriteLine("It's like someone was here recently...");
            Console.WriteLine("(*and since someone was here, then there must be something interesting here)");

            int option;

            Console.WriteLine("\nAvailable actions:");
            Console.WriteLine("1. Return back to the gym");

            if (!hasKey)
            {
                Console.WriteLine("2. Search the premises");
                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            if (option == 1)
            {
                Console.WriteLine("Go back...");
                roomNumber = 2;
            }
            else
            {
                Console.WriteLine("Within a few(perhaps tens) of minutes, you examine the entire room.");
                Console.WriteLine("Apart from some furniture and rags, there is nothing interesting, although...");
                Console.WriteLine("You see something shiny next to the fireplace, and without hesitation you move towards it.");
                Console.WriteLine("Congratulations, you found the key... But what is it from?");

                hasKey = true;
            }

            Console.ReadLine();
        }

        static void ActionDangerRoom()
        {
            Console.Clear();
            Console.WriteLine("As soon as you entered the room, you immediately felt uncomfortable.");
            Console.WriteLine("From here you want to run away as soon as possible, your whole gut tells you about it.");
            Console.WriteLine("It is very dark in this room, but you seem to see a beam of light in the distance to the left.");
            Console.WriteLine("Available actions:");
            Console.WriteLine("1.Return back to the stone hall");
            Console.WriteLine("2.Run to the light");
            Console.WriteLine("3.Explore the dark corners of this room");

            int option = GetIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Go back...");
                roomNumber = 2;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("As you got closer to the light, you realized that this light was coming from the door.");
                Console.WriteLine("In this dark room, you were not comfortable, without thinking twice, you go inside.");
                roomNumber = 5;
                Console.ReadLine();
            }
            else Death();

        }

        static void Death()
        {
            Console.WriteLine("Having reached the dark parts of the hall, you are trembling all over your body.");
            Console.WriteLine("Something is definitely hidden in this dark abyss and it seems to be moving towards you.");
            Console.WriteLine("You try to run back, but the fear is so strong that you barely managed to turn around.");
            Console.WriteLine("You know this is the end...");
            Console.WriteLine("I should have listened to my intuition...");

            Console.ReadLine();

            Environment.Exit(0);
        }

        static void ActionQuestRoom()
        {
            Console.Clear();
            Console.WriteLine("And it's pretty cozy in here.");
            Console.WriteLine("The hall is small, in front there is some kind of door with a strange lock.");
            Console.WriteLine("There is something painted on the walls in silver paint.");
            Console.WriteLine("Available actions:");
            Console.WriteLine("1. Return back to the scary hall");
            Console.WriteLine("2. Go to the door with a lock");

            int option = GetIntInRange(1);

            if (option == 1)
            {
                Console.WriteLine("Go back...");
                roomNumber = 4;
                Console.ReadLine();
            }
            else CompleteQuest();
        }

        static void CompleteQuest()
        {
            Console.WriteLine("Approaching the door, you found that a combination lock hangs on it.");
            Console.WriteLine("To open it, you need to enter a word of 9 letters, hmm... what is this word...");
            Console.WriteLine("After a short thought, you decide to look at the inscriptions on the walls, they say:");
            Console.WriteLine("======================================================");

            Console.WriteLine("To all things and men I appertain,");
            Console.WriteLine("and yet by some am shunned and distained.");
            Console.WriteLine("Fondle me and ogle me til you're insane,");
            Console.WriteLine("but no blow can harm me, cause me pain.");
            Console.WriteLine("Children delight in me, elders take fright.");
            Console.WriteLine("Fair maids rejoice and spin.");
            Console.WriteLine("Cry and I weep, yawn and I sleep.");
            Console.WriteLine("Smile, and I shal grin.");
            Console.WriteLine("What am I?");

            Console.WriteLine("Write a word:");

            string answer = Console.ReadLine();

            while (answer.ToLower() != "mirror")
            {
                Console.WriteLine("Wrong word. Try again:");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Room is opened. You go in.");
            roomNumber = 6;
            Console.ReadLine();
        }

        static void ActionOtherShip()
        {
            Console.Clear();
            Console.WriteLine("Going inside you see a ruined hall, light pours through the ceiling.");
            Console.WriteLine("The hole at the top was made by your commander's ship...");
            Console.WriteLine("The ship sank into the floor, a deplorable state...");
            Console.WriteLine("However, the door is open, you go inside, unfortunately there is no one there.");

            if (!hasModule)
            {
                Console.WriteLine("There is no time to deal with this, you need to find the power module if it survived.");
            }

            int option;

            Console.WriteLine("Available actions:");
            Console.WriteLine("1. Return to the mystery room");

            if (!hasModule)
            {
                Console.WriteLine("2. Inspect the ship's power module");
                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            ChooseOptionsInOtherShip(option);
        }

        static void ChooseOptionsInOtherShip(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Go back...");
                roomNumber = 5;
            }
            else
            {
                Console.WriteLine("Approaching the energy module, you are happy to discover,");
                Console.WriteLine("that the indicator shows a tenth of the charge. That should be enough to fly!");
                Console.WriteLine("This ship is in disrepair, you will have to return to your own.");
                Console.WriteLine("You carefully remove the power module, now you can go back.");
                hasModule = true;
            }
            Console.ReadLine();
        }

        static void Conclusion()
        {
            Console.WriteLine("End of the game! You flew off the planet!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void Introduction()
        {
            Console.WriteLine("You vaguely remember where you are... even who you are...");
            Console.ReadLine();
            Console.WriteLine("The body is squeezed, but your brain is already giving signals to life...");
            Console.ReadLine();
            Console.WriteLine("At lightning speed you remember the last 24 hours...");
            Console.WriteLine("You, as part of the 3rd squadron, were sent on patrol near Keplan-7.");
            Console.ReadLine();
            Console.WriteLine("The last 10 minutes that you remember is how vainly you tried to get out of this magnetic hook.");
            Console.WriteLine("We'll deal with what happened later. Now we need to find fuel.");
            Console.WriteLine("Or at best, you need to at least leave the ship.");
        }

        static int GetIntInRange(int optionsNumber)
        {

            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionsNumber;

            while (!isConverted)
            {
                Console.WriteLine("Wrong option, try again!");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionsNumber;
            }

            return number;
        }
    }
}
