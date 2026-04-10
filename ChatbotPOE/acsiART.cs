using System;
using static System.Console;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    public class acsiART
    {


        public static void DisplayWelcome()
        {
             
            // gets the color for the acsii art
            ForegroundColor = Cyan;
            WriteLine(@"
╔══════════════════════════════════════════════════════════════════════════════════════════╗
║   ______      __               _____                      _ __           ___             ║
║  / ____/_  __/ /_  ___  _____/ ___/___  _______  _______(_) /___  __   /   |  ____  ____ ║
║ / /   / / / / __ \/ _ \/ ___/\__ \/ _ \/ ___/ / / / ___/ / __/ / / /  / /| | / __ \/ __ \║
║/ /___/ /_/ / /_/ /  __/ /   ___/ /  __/ /__/ /_/ / /  / / /_/ /_/ /  / ___ |/ /_/ / /_/ /║
║\____/\__, /_.___/\___/_/   /____/\___/\___/\__,_/_/  /_/\__/\__, /  /_/  |_/ .___/ .___/ ║
║     /____/                                                 /____/         /_/   /_/      ║
╚══════════════════════════════════════════════════════════════════════════════════════════╝
                ");
            ResetColor();
        }


        //the === that appears at the top of the page
        public static void Header(string text)
        {
            string upper = text.ToUpper();

            ForegroundColor = Cyan;
            WriteLine("\n" + upper);
            WriteLine(new string('=', upper.Length));
            ResetColor();
        }


        //user input responeses
        public static void UserLine (string text)
        {
            ForegroundColor = Cyan;
            Write($"[You]: ");
            WriteLine(text);

        }

        //chatboot responeses
        public static void BotLine (string text)
        {
            ForegroundColor = Magenta;
            Write("[Chatbot]: ");
            ResetColor(); ;
            WriteLine(text);
        }


        //divider for each section 
        public static void Divider()
        {
            ForegroundColor = White;
            WriteLine(new string('-', 60));
            ResetColor();
        }



        public static void SystemLine(string text)
        {
            ForegroundColor = Yellow;
            Write("[Chatbot]: ");
            ResetColor();
            WriteLine(text);
        }


        //function that shows each user prompt
        public static void UserPrompt(string name)
        {
            ForegroundColor = Yellow;
            Write($"\n[{name}]: ");
            ResetColor();
        }


        //Shows chatbots response
        public static void BotLine(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Write("[Chatbot]: ");
            ResetColor();

            ForegroundColor = color;
            WriteLine(text);
            ResetColor();
        }


    }
}