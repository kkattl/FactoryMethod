using Newtonsoft.Json;
using System.IO;


namespace lab3.Document
{
    public class Order : Document
    {
        private string _department;
        private string _deadline;
        private string _responsiblePerson;

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
        public string ResponsiblePerson
        {
            get { return _responsiblePerson; }
            set { _responsiblePerson = value; }
        }

        public override string ToString()
        {
            return $"Order\nNumber: {Number}\nDate: {Date}\nDepartment: {Department}\nDeadline: {Deadline}\nResponsiblePerson: {ResponsiblePerson}\nInformation: {Information}\n";
        }

        public override void Saving()
        {
            var documentObject = new
            {
                Number,
                Date,
                Department,
                Deadline,
                ResponsiblePerson,
                Information
            };


          
            string json = JsonConvert.SerializeObject(documentObject, Formatting.Indented);

            string folderPath = @"C:\Users\Admin\source\repos\lab3\Results\Orders";
            string fileName = "Order" + Number + ".json";
            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, json);
        }
      

    }
}
