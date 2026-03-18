using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Cybersecurity Awareness Chatbot";

            acsiART.DisplayWelcome();

            //border clear
            Clear();
            acsiART.DrawBorder(Cyan);
            SetCursorPosition(2, 1);

            acsiART.DisplayWelcome();

            

            

            //instance of chatbot logic
            acsiART art = new acsiART();
            Chatbot bot = new Chatbot();

            bot.TypeMessage("Press any key to start the application.....", Yellow);
            ReadKey();

            //title window
            Title = "Cybersecurity Awareness Assistant";

            //start experience?
            bot.PlayVoiceGreeting();
            //bot.DisplayLogo();

            bot.TypeMessage("Welcome to the Cybersecurity Awareness ChatBot", Cyan);
            Write("\nGooday user please enter your name:  ");
            String name = ReadLine();

            //if name field is empty
            if (string.IsNullOrWhiteSpace(name)) name = "Citizen"; //fix this !!!!!

            bot.TypeMessage($"\nHello {name}! Goodday i am here to help you to stay safe online.", Green);
            WriteLine("****************************************************");
            bot.TypeMessage("Type any questions related to passwords or phishing below. Or type (exit) to quit");

            //this is the main interactiion loop
            while (true)
            {
                Write($"\n{name}: ");
                string userInput = ReadLine();

                //end condition
                if(!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower().Trim()=="exit")
                {
                    bot.TypeMessage($"Goodbye {name}", Magenta);
                    break;
                }

                Write("Chatbot: ");
                bot.HandleUserQuery(userInput, name);
            }

            acsiART.DrawHorizontalLine('*', Cyan);
        }
    }
}
