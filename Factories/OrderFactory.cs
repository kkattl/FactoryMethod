using lab3.Document;
using System;

namespace lab3.Factories
{
    public class OrderFactory : DocumentFacory
    {
        public override IDocument ConsoleCreation()
        {
            Order document = new Order();

            Console.WriteLine("Enter department");
            document.Department = Console.ReadLine();
            Console.WriteLine("Enter deadline");
            document.Deadline = Console.ReadLine();
            Console.WriteLine("Enter responsible persone");
            document.ResponsiblePerson = Console.ReadLine();
            Console.WriteLine("Enter information");
            document.Information = Console.ReadLine();

            document.ToString();
            document.Saving();
            return document;
        }

    }
}
