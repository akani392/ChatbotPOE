using System;
using static System.Console;
using System.Speech.Synthesis;
using System.Media;
using System.Threading;
using System.Collections.Generic;
using static System.ConsoleColor;

namespace ChatbotPOE
{
    public class Chatbot
    {
        public void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"Recording/recording.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing sound: " + ex.Message);
            }
        }

        public void TypeMessage(string message, ConsoleColor color = White)
        {
            ForegroundColor = color;
            foreach (char c in message)
            {
                Write(c);
                Thread.Sleep(25);
            }
            WriteLine();
            ResetColor();
            //finnd out more about this 
        }

        public void HandleUserQuery(string input, string userName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                acsiART.WriteLineWithBorder($"I can not find you you have entered, {userName}. Please try again.", Yellow);
                return;
            }

            string query = input.ToLower().Trim();
            

           
           
               
            

            
                if (query.Contains("how are you"))
                {
                    acsiART.WriteLineWithBorder("Bot: I am good i am working nicley and i am ready to help you to stay safe online", Magenta);
                }
                else if (query.Contains("purpose"))
                {
                    acsiART.WriteLineWithBorder("Chatbot: My purpose is for me to be able to give you more knowledge on cybersecurity threats such as phishing and scams.", Magenta);

                }
                else if (query.Contains("ask")|| query.Contains("help"))
                {
                    acsiART.WriteLineWithBorder("Chatbot: Safe browsing is usually when going in websites that have https sites and do not press on any suspicious pop-ups", Magenta);
                }
                else
                {
                    acsiART.WriteLineWithBorder("Chatbot: I did not understand what you typed, can you please type your question again", DarkRed);
                }
            }
        }
    }
