using lab3.Document;
using System;

namespace lab3.Factories
{
    public class ResourceRequestFactory : DocumentFacory
    {
        public override IDocument ConsoleCreation()
        {
            ResourceRequest document = new ResourceRequest();

            Console.WriteLine("Enter employee");
            document.Employee = Console.ReadLine();
            Console.WriteLine("Enter resourses");
            document.Resources = Console.ReadLine();
            Console.WriteLine("Enter information");
            document.Information = Console.ReadLine();

            document.ToString();
            document.Saving();
            return document;
        }
    }
}
