using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace lab3.Document
{
    public class Directive : Document
    {
        private string _department;
        private string _deadline;
        
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }

        public override string ToString()
        {
            return $"\nDirective\nNumber: {Number}\nDate: {Date}\nDepartment: {Department}\nDeadline: {Deadline}\nInformation: {Information}\n";
        }



        public override void Saving()
        {
            var documentObject = new
            {
                Number,
                Date,
                Department,
                Deadline,
                Information
            };


           
            string json = JsonConvert.SerializeObject(documentObject, Formatting.Indented);

            string folderPath = @"C:\Users\Admin\source\repos\lab3\Results\Directives";
            string fileName = "Directive" + Number + ".json";
            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, json);
        }
     
    }
}

