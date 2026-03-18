using System;
using static System.Console;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    public class acsiART
    {

        public static void DrawHorizontalLine(char borderChar, ConsoleColor color)
        {
            string line = new string(borderChar, WindowWidth - 1);
            WriteLine(line);
            ResetColor();
        }

        public static void DisplayWelcome()
        {
             

            ForegroundColor = Cyan;
            WriteLine(@"
    __      __  ______  _         _____   ____   __  __  ______ 
 \ \    / / |  ____|| |       / ____| / __ \ |  \/  ||  ____|
  \ \  / /  | |__   | |      | |     | |  | || \  / || |__   
   \ \/ /   |  __|  | |      | |     | |  | || |\/| ||  __|  
    \  /    | |____ | |____  | |____ | |__| || |  | || |____ 
     \/     |______||______|  \____| \____/ |_|  |_||______|
                                                             
                     _______   ____                          
                    |__   __| / __ \                         
                       | |   | |  | |                        
                       | |   | |  | |                        
                       | |   | |__| |                        
                       |_|    \____/                         
                                                             
        _____  _    _             _______  ____   ____ _______ 
       / ____|| |  | |     /\    |__   __||  _ \ / __ \__   __|
      | |     | |__| |    /  \      | |   | |_) | |  | | | |   
      | |     |  __  |   / /\ \     | |   |  _ <| |  | | | |   
      | |____ | |  | |  / ____ \    | |   | |_) | |__| | | |   
       \_____||_|  |_| /_/    \_\   |_|   |____/ \____/  |_|
            ");
            ResetColor();
        }

        //page border
        public static void DrawBorder(ConsoleColor color)
        {
            ForegroundColor = color;
            int width = WindowWidth - 1;
            int height = WindowHeight - 1;

            for(int i = 0; i <= width; i++)
            {
                SetCursorPosition(i, 0);
                Write("*");
                SetCursorPosition(i, height);
                Write("*");
            }

            //draw sides
            for (int i = 1; i < height; i++)
            {
                SetCursorPosition(0, i);
                Write("*");
                SetCursorPosition(width, i);
                Write("*");
            }

            //draw floor line
            SetCursorPosition(0, 0);
            Write("*");
            SetCursorPosition(width, 0);
            Write("*");
            SetCursorPosition(0, height);
            Write("*");
            SetCursorPosition(width, height);
            Write("*");

            ResetColor();
        }

        public static void WriteLineWithBorder (string text, ConsoleColor textColor)
        {
            int width = WindowWidth - 1;
            string sideChar = "*";

            //calculates how much space is needd
            int paddingAmount = width - text.Length - 4;

            if (paddingAmount < 0) paddingAmount = 0;

            Write(sideChar + " ");
            ForegroundColor = textColor;
            Write(text);
            ResetColor ();

            Write(new string(' ', paddingAmount) + " " + sideChar + "\n");
        }
        
    }
}