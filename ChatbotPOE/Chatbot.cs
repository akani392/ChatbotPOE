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
            string[] keywords = {
                "how are you","purpose", "help", "password", "phishing", "link", "scam", "https", "mfa"
            };

            string[] responses = {
                "I'm functioning perfectly and ready to help you secure your digital life",
                "My purpose is to be your personal cybersecurity mentor and keep you safe from online threats.",
                "I can help with: Passwords, Phishing, Scams, MFA, and Safe Browsing. Just type a keyword",
                "Strong passwords use a mix of uppercase, lowercase, numbers, and symbols. Avoid using your name or birthdate!",
                "Phishing is a trick where hackers send fake emails. Look for bad grammar and urgent demands for money.",
                "Before you click, hover your mouse over the link to see the real URL. If it looks suspicious, don't click",
                "Online scams often promise 'free' gifts or claim your bank account is locked. Never give your PIN to anyone.",
                "HTTPS means the website is encrypted. Look for the padlock icon in your browser address bar before entering data.",
                "Multi-Factor Authentication (MFA) adds a second layer of security, like a code sent to your phone. Always enable it!"
            };

            // Check dictionary
            for (int i = 0; i < keywords.Length; i++)
            {
                if (query.Contains(keywords[i]))
                {
                    return (responses[i], Green);
                }
            }

 

            // Default response
            return ("I did not understand that. Try asking about passwords, phishing, or scams.", Red);
        }
    }
    }
    
