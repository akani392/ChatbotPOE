using System;
using static System.Console;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    public class acsiART
    {


        public static void DisplayWelcome()
        {
             

            ForegroundColor = Cyan;
            WriteLine(@"
                   ┌──────────────┐
                   │  CHATBOT CO  │
                   └──────────────┘
                        [● ●]
                         ───
                        \___/
                         ││
                       ──┴┴──
            ");
            ResetColor();
        }



        public static void Header(string text)
        {
            string upper = text.ToUpper();

            ForegroundColor = Cyan;
            WriteLine("\n" + upper);
            WriteLine(new string('=', upper.Length));
            ResetColor();
        }

        public static void UserLine (string text)
        {
            ForegroundColor = Cyan;
            Write($"[You]: ");
            WriteLine(text);

        }

        public static void BotLine (string text)
        {
            ForegroundColor = Magenta;
            Write("[Chatbot]: ");
            ResetColor(); ;
            WriteLine(text);
        }

         
        //divides each comment section
        public static void Divider()
        {
            ForegroundColor = DarkGray;
            WriteLine(new string('-', 60));
            ResetColor();
        }



        public static void SystemLine (string text)
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