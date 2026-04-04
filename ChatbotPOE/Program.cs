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

            Write("\nEnter your name: ");
            string name = ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                name = "Citizen";


            bot.TypeMessage($"[Chatbot]: Hello {name}! I will help you stay safe online.", Green);

            acsiART.Divider();

            acsiART.SystemLine("Ask about passwords, phishing, safe browsing, https, you can even ask questions like how are you, purpose, help.");
            acsiART.SystemLine("Type 'exit' to quit.");



            //this is the main interactiion loop
            while (true)
            {
                acsiART.UserPrompt(name);
                string userInput = ReadLine();

                if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower().Trim() == "exit")
                {
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
