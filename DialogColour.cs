using System;

namespace theGladiatorsLabyrinth
{
    class DialogColour
    {

        public static void StoryLine_Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void Progress_Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void NPC_Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }


        public static void TheAlchemyst_Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
