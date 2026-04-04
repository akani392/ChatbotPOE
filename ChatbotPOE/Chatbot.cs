using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Security.Policy;
using System.Speech.Synthesis;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    public class Chatbot
    {

        //voice recording
        public void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"Recording/Recording2.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing sound: " + ex.Message);
            }
        }

        //loop function
        public void TypeMessage(string message, ConsoleColor color)
        {
            ForegroundColor = color;

            foreach (char c in message)
            {
                Write(c);
                Thread.Sleep(15); 
            }

            WriteLine();
            ResetColor();
        }


        //error meassage
        public (string message, ConsoleColor color) GetResponse(string input, string userName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return ($"I cannot understand what you entered, {userName}. Please try again.", Yellow);
            }



            string query = input.ToLower().Trim();


            //array for dictnoary function
            string[] keywords = { "how are you", "purpose", "ask", "password", "phishing", "link", "scam" };

            string[] responses = {
                "I am doing good and i am ready to help you stay safe online",
                "The purpose of this application is to educate users about cybersecurity threats",
                "You can ask questions about passwords,phishing, scams, and safe browsing.",
                "You can ask questions about passwords, phishing,and safe browsing",
                "A strong password should be\r\nat least 12 characters long and include letter numbers, and symbols.",
                "Phishing is when attackers use fake emails or websites to trick you into giving persona information.",
                "Always hover over a link to see where it leads before clicking.",
                "Scams are fraudulent attempts to steal your money or information. Always verify sources before trusting them."
             };

            // Check dictionary
            for (int i = 0; i < keywords.Length; i++)
            {
                if (query.Contains(keywords[i]))
                {
                    return (responses[i], Magenta);
                }
            }

            // Default response
            return ("I did not understand that. Try asking about passwords, phishing, or scams.", Red);
        }
    }
    }
    
