using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using NAudio.SoundFont;
using System.Speech.Synthesis;
using System.Net.Http.Headers;
using Microsoft.VisualBasic;
namespace ChatbotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play the voice greeting
            PlayVoiceGreeting();

            // Display ASCII art (Cybersecurity Awareness Bot logo)
            DisplayAsciiLogo();

            // Greet the user and ask for their name
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Invalid input of username. Please try again.");
                return; 
            }
            Console.WriteLine($"Hello, {userName}! Welcome to the Cybersecurity Awareness Bot!");

            // Simulate typing effect and ask user about how they need help
            TypeText("The chatbot is here to help you stay safe online by providing some cybersecurity tips...");

            // Respond to basic user queries
            RespondToQueries();

            // Example input validation handling
            InputValidation();
        }

        // Method to play the voice greeting when the chatbot starts
        static void PlayVoiceGreeting()
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                Console.WriteLine("Hello!!Welcome to the Cybersecurity Awareness chatbot!");
                synth.Speak("Hello!!Welcome to the Cybersecurity Awareness chatbot!, Feel free to ask me anything about online safety.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error has occured whilst playing the voice greeting: " + ex.Message);
            }
        }

        // Method to display the ASCII logo or art of the chatbot
        static void DisplayAsciiLogo()
        {
            Console.WriteLine(@"
  _____ _               _____                        
 / ____| |             / ____|                       
| |    | |_   _  ___  | |     ___   ___  __ _ _ __  
| |    | | | | |/ _ \ | |    / _ \ / _ \/ ` | ' \ 
| || | || |  __/ | || () |  __/ (| | | | |
 \||\,|\|  \\/ \|\,|| || 
");
        }

        // Method to simulate typing effect
        static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50); // Simulate typing delay
            }
            Console.WriteLine();
        }

        // Method to respond to user queries about the chatbot's purpose
        static void RespondToQueries()
        {
            Console.WriteLine("Feel free to ask me anything about cybersecurity. Type 'exit' to quit.");
            string input;
            while ((input = Console.ReadLine().ToLower()) != "exit")
            {
                if (input == "how are you?")
                {
                    Console.WriteLine("I'm good, thank you for asking!");
                }
                else if (input == "How may I assist you today?")
                {
                    Console.WriteLine("My duty is to assist & you with staying safe online by providing cybersecurity tips and answering your questions.");
                }
                else if (input == "what type of questions are relevant to ask?")
                {
                    Console.WriteLine("You can ask me questions about password safety, phishing, and How one can stay safe online.");
                }
                else
                {
                    Console.WriteLine("May you please explain, I found it hard to understand at first");
                }
            }
        }

        // Method to handle input validation and guide the user if no valid input is entered
        static void InputValidation()
        {
            Console.Write("You may ask questions based on how to stay safe online: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Error occurred... Please try asking your question again.");
            }
            else
            {
                Console.WriteLine("Thank you for your input! Please let us know for more assistance if needed.");
            }
        }
    }
}
