using System;
using System.Text;
using UserServiceTestApp.UserService;


namespace UserServiceTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string exceptionMessage;

            exceptionMessage = "Exception caught: {0}";
            try
            {
                ReadConsoleInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine(exceptionMessage, ex.Message);
            }
        }

        private static void ReadConsoleInput()
        {
            string input;
            int userId;
            string startMessage;
            string outputMessage;
            string warningMessage;
            string noUserMessage;
            UserServiceClient usClient;
            ConsoleKeyInfo consoleKey;
            StringBuilder sBuilder;
 
            consoleKey = new ConsoleKeyInfo();
            usClient = new UserServiceClient();
            sBuilder = new StringBuilder();
            startMessage = "Enter your name and press ENTER.  (ESC to cancel): ";
            outputMessage = "\r\nUser {0} by Id {1}.";
            warningMessage = "\r\nPlease enter a correct number.";
            noUserMessage = "\r\nUser does not exist with Id {0}.";

            Console.Write(startMessage + Environment.NewLine);

            while (true)
            {
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (consoleKey.Key == ConsoleKey.Enter)
                {
                    input = sBuilder.ToString();
                    sBuilder.Clear();
                    if (Int32.TryParse(input, out userId))
                    {
                        var user = usClient.GetUser(userId);
                        if (user == null)
                        {
                            Console.WriteLine(noUserMessage, userId);
                        }
                        else
                        {
                            Console.WriteLine(outputMessage, user.Name, user.Id);
                        }
                    }
                    else
                    {
                        Console.WriteLine(warningMessage);
                    }
                    Console.WriteLine(startMessage);
                }
                else
                {
                    sBuilder.Append(consoleKey.KeyChar);
                }
            }
        }
    }
}
