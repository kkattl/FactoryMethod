using System.IO;
using Newtonsoft.Json;

namespace lab3.Document
{
    public class ResourceRequest : Document
    {
        private string _employee;
        private string _resources;

        public string Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public string Resources
        {
            get { return _resources; }
            set { _resources = value; }
        }
        public override string ToString()
        {
            return $"ResourceRequest\nNumber: {Number}\nDate: {Date}\nInformation: {Information}\nEmployee: {Employee}\nResources: {Resources}";
        }
        public override void Saving()
        {
            var documentObject = new
            {
                Number,
                Date,
                Information,
                Employee,
                Resources
            };


            string json = JsonConvert.SerializeObject(documentObject, Formatting.Indented);


            string folderPath = @"C:\Users\Admin\source\repos\lab3\Results\ResourceRequest";
            string fileName = "ResourceRequest" + Number + ".json";
            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, json);
        }

    }
    }
