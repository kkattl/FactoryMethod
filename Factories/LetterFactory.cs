using lab3.Document;
using System;

namespace lab3.Factories
{
    public class LetterFactory : DocumentFacory
    {
        public override IDocument ConsoleCreation()
        {
            Letter document = new Letter();

            Console.WriteLine("Enter corespondent");
            document.Correspondent = Console.ReadLine();
            Console.WriteLine("Is letter income? Answer must be true or false)");
            string input = Console.ReadLine();
            document.IsIncoming = bool.TryParse(input, out bool isIncoming) ? isIncoming : false;
            Console.WriteLine("Enter information");
            document.Information = Console.ReadLine();

            document.ToString();
            document.Saving();
            return document;
        }
    }
    }
