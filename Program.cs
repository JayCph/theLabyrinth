using System;

namespace theGladiatorsLabyrinth
{

    public static class Game
    {
        static string PlayerName = "John Doe";

        public static void StartGame()
        {
            Console.WriteLine("Welcome to \n");
            DialogColour.Progress_Dialog(@"
               _____  _             _            _                   _         _    _     
              |_   _|| |__    ___  | |     __ _ | |__   _   _  _ __ (_) _ __  | |_ | |__  
                | |  | '_ \  / _ \ | |    / _` || '_ \ | | | || '__|| || '_ \ | __|| '_ \ 
                | |  | | | ||  __/ | |___| (_| || |_) || |_| || |   | || | | || |_ | | | |
                |_|  |_| |_| \___| |_____|\__,_||_.__/  \__, ||_|   |_||_| |_| \__||_| |_|
                                                        |___/                             
               
               ~~ ** A small interactive text based adventure game by Janus B. Reedtz ** ~~                                
            ");

            Console.ReadKey();

            Console.WriteLine("\n\n\nThe Gladiator's Labyrinth is a text based Adventure Game written in C# while studying an AP in Software Development.\n\n");

            DialogColour.Progress_Dialog("Hit any key to embark on the adventure");
            Console.ReadKey();
            Console.Clear();

            NameCharacter();

            Choice();
        }

        static void NameCharacter()
        {

            bool confirmed = false;
            string PlayerName;
            do
            {
                Console.WriteLine("To begin your quest, enter the name of your character: ");
                PlayerName = Console.ReadLine();
                Console.WriteLine($"\nYour chosen character name is: {PlayerName}");

                ConsoleKey response;
                do
                {
                    Console.WriteLine($"Are you sure {PlayerName} is the name you want to move forward with? [y/n]");
                    response = Console.ReadKey(false).Key;
                    if (response != ConsoleKey.Enter)
                        Console.WriteLine();

                } while (response != ConsoleKey.Y && response != ConsoleKey.N);

                confirmed = response == ConsoleKey.Y;
            } while (!confirmed);
            Console.WriteLine($"You chose the name {PlayerName} for your character, let the games commence!");
            Console.ReadKey();
            Console.Clear();

            DialogColour.TheAlchemyst_Dialog($"\n\"{PlayerName}, it is my unfortunate duty to inform you, that you more than likely, \n" +
                $"won't be making it out of the Labyrinth alive, so best of luck, surely you will need it!\" ");
            Console.Write("- The Alchymist");
        }

        static void Choice()
        {
            string input = "";
            DialogColour.StoryLine_Dialog(PlayerName + ", which will you choose? A or B?");
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "A")
            {
                DialogColour.StoryLine_Dialog("You hear a booming voice somewhere in the distance: \n");
                DialogColour.TheAlchemyst_Dialog(PlayerName + "ooh so you have chosen path A... an interesting, and dangerous, choice!");
            }
            else
            {
                DialogColour.StoryLine_Dialog("You hear a booming voice somewhere in the distance: \n");
                DialogColour.TheAlchemyst_Dialog(PlayerName + "ooh so you have chosen path B... an interesting, and dangerous, choice!");
            }
        }

    }
    class Item
    {

    }


    class Program
    {
        static void Main()
        {
            Game.StartGame();

            Console.ReadKey();

            //Console.WriteLine("You feel a drop of sweat run down your forehead as you look up from the dusty sand.");
            //Console.WriteLine("You look into the back of another of the capturerd ex-soldiers, " +
            //    "as you are all being chased off the boat");
            //Console.WriteLine("A long dusty roads streches and curves in front of you up the hill where you're able");
            //Console.WriteLine("to see the walls of a fortress up ahead. Heat waves are blurring the fortress walls, ");
            //Console.WriteLine("as the sun hits its peak on the blue sky above your sweaty heads.");
        }
    }
}
