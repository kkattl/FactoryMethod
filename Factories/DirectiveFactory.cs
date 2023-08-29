using lab3.Document;
using System;

namespace lab3.Factories
{
    public class DirectiveFactory : DocumentFacory
    {
        public override IDocument ConsoleCreation()
        { 
            Directive document = new Directive();

            Console.WriteLine("Enter department");
            document.Department = Console.ReadLine();
            Console.WriteLine("Enter deadline");
            document.Deadline = Console.ReadLine();
            Console.WriteLine("Enter information");
            document.Information = Console.ReadLine();

            document.Saving();
            return document;
        }
    }
}
