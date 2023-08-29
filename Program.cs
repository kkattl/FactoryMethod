using lab3.Document;
using lab3.Factories;
using System;


namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Choose type of document:");
                Console.WriteLine("1. Letter");
                Console.WriteLine("2. Order");
                Console.WriteLine("3. Directive");
                Console.WriteLine("4. Resource Request");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());


                IDocument document = null;

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        DocumentFacory letterFactory = new LetterFactory();
                        document = letterFactory.ConsoleCreation();
                        break;
                    case 2:
                        DocumentFacory orderFactory = new OrderFactory();
                        document = orderFactory.ConsoleCreation();
                        break;
                    case 3:
                        DocumentFacory directiveFactory = new DirectiveFactory();
                        Console.WriteLine("Enter department");
                        Console.ReadLine();
                        document = directiveFactory.ConsoleCreation();
                        break;
                    case 4:
                        DocumentFacory resourceRequest = new ResourceRequestFactory();
                        document = resourceRequest.ConsoleCreation();
                        break;
                    default:
                        Console.WriteLine("Incorect choose");
                        break;
                }
                Console.WriteLine(document.ToString());
                Console.WriteLine();
            }

        }
    }
}
