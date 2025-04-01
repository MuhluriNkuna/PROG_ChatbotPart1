using System;
using System.Threading;
using System.Media;
using System.IO;

namespace CybersecurityChatbot
{
    class CyberAwarenessBot
    {
        static void Main(string[] args)
        {
            // Display the CyberX ASCII logo
            DisplayAsciiLogo();

            // Play the voice greeting
            DisplayVoiceGreeting();

            // Greet the user and ask for their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHello, welcome to CyberX – How can I help you?");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Personalize the greeting
            Console.WriteLine($"\nHello, {userName}! I'm here to help you stay safe online. Let's get started!");
            Console.ResetColor();

            // Main conversation loop
            bool continueChat = true;
            while (continueChat)
            {
                // Clear the screen for a fresh look each time
                Console.Clear();

                // Ask the user for input
                Console.WriteLine("\nWhat would you like to learn about today?");
                Console.WriteLine("1. Password Safety");
                Console.WriteLine("2. Phishing Attacks");
                Console.WriteLine("3. Safe Browsing Tips");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string userChoice = Console.ReadLine();

                // Respond based on user choice
                switch (userChoice)
                {
                    case "1":
                        DisplayPasswordSafetyTips();
                        break;
                    case "2":
                        DisplayPhishingTips();
                        break;
                    case "3":
                        DisplaySafeBrowsingTips();
                        break;
                    case "4":
                        continueChat = false;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nThank you for chatting with CyberX! Stay safe online.");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oops! I didn't quite understand that. Please choose a number between 1 and 4.");
                        Console.ResetColor();
                        break;
                }

                // Pause and wait for the user to press any key before continuing
                if (continueChat)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void DisplayVoiceGreeting()
        {
            try
            {
                string audioFilePath = "welcome.wav"; // Ensure the file exists or use an absolute path

                if (File.Exists(audioFilePath))
                {
                    SoundPlayer soundPlayer = new SoundPlayer(audioFilePath);
                    soundPlayer.PlaySync();
                }
                else
                {
                    Console.WriteLine("Welcome message audio file not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while trying to play the sound: {ex.Message}");
                Console.WriteLine("Please ensure the 'welcome.wav' file exists and is accessible.");
            }
        }

        static void DisplayAsciiLogo()
        {
            string asciiLogo = @"
   CCCCC    Y   Y   BBBBB     EEEEE    RRRRR    X     X  
  C          Y Y    B    B    E        R   R     X   X 
  C           Y     BBBBB     EEEE     RRRRR       X         
  C           Y     B    B    E        R   R      X X    
   CCCCC      Y     BBBBB     EEEEE    R    R   X     X 
";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(asciiLogo);
            Console.ResetColor();
            Console.WriteLine("Loading CyberX...");
            Thread.Sleep(1000); // Shortened the delay for better UX
        }

        static void DisplayPasswordSafetyTips()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPassword Safety Tips:");
            Console.WriteLine("- Use at least 12 characters (longer passwords are better).");
            Console.WriteLine("- Include numbers, symbols, and both uppercase and lowercase letters.");
            Console.WriteLine("- Don't reuse passwords across multiple sites.");
            Console.WriteLine("- Use a password manager to store your passwords safely.");
            Console.ResetColor();
        }

        static void DisplayPhishingTips()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPhishing Attack Tips:");
            Console.WriteLine("- Be cautious of unsolicited emails and messages asking for personal information.");
            Console.WriteLine("- Verify the sender's email address carefully.");
            Console.WriteLine("- Avoid clicking on links in suspicious emails, especially if they seem urgent.");
            Console.WriteLine("- Look for spelling mistakes and grammatical errors in suspicious messages.");
            Console.ResetColor();
        }

        static void DisplaySafeBrowsingTips()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSafe Browsing Tips:");
            Console.WriteLine("- Use HTTPS websites for secure browsing (look for the padlock symbol).");
            Console.WriteLine("- Avoid downloading files or clicking on pop-up ads from unknown sources.");
            Console.WriteLine("- Keep your browser and antivirus software up-to-date.");
            Console.WriteLine("- Always log out of your accounts when you’re done, especially on public computers.");
            Console.ResetColor();
        }
    }
}
