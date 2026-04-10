using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance of chatbot logic
            acsiART art = new acsiART();


            Title = "Cybersecurity Awareness Assistant";
            Clear();

            acsiART.DisplayWelcome();

            // HEADER
            acsiART.Header("Cybersecurity Awareness Chatbot");

            Chatbot bot = new Chatbot();

            //voice part
            bot.PlayVoiceGreeting();

            // Welcome
            acsiART.SystemLine("Press any key to start...");
            ReadKey();

            acsiART.Divider();

            

            
            //welcome message
            bot.TypeMessage("[Chatbot]: Welcome to the Cybersecurity Awareness Chatbot", Cyan);

            string name = "";

            //loop if name is more than 2 letters
            while (true)
            {
                Write("\nEnter your name: ", Magenta);
                name = ReadLine();

                if (string.IsNullOrWhiteSpace(name) || name.Trim().Length <2)
                {
                    WriteLine("Please put in your name again. Your name must be more than 2 letters long ", Red);
                }
                else
                {
                    break;
                }
            }

          


            bot.TypeMessage($"[Chatbot]: Hello {name}! I will help you stay safe online.", Magenta);

            acsiART.Divider();

            acsiART.SystemLine("Ask anything like, how are you, purpose, help, password, phishing, link, scam, https, mfa.");
            acsiART.SystemLine("Type 'exit' to quit.");

            acsiART.Divider();

            //this is the main interactiion loop
            while (true)
            {
                acsiART.UserPrompt(name);
                string userInput = ReadLine();

                if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower().Trim() == "exit")
                {
                    acsiART.Divider();

                    acsiART.BotLine($"Goodbye {name}! Stay safe online.", Magenta);
                    break;
                }

                var result = bot.GetResponse(userInput, name);

                // slight delay for realism
                Thread.Sleep(300);

                acsiART.BotLine(result.message, result.color);
            }
        }
    }
}
