using Newtonsoft.Json;
using System;
using System.IO;

namespace lab3.Document
{
    public class Letter : Document 
    {

        private string _correspondent;
        private bool _isIncoming;
      
        public string Correspondent
        {
            get { return _correspondent; }
            set { _correspondent = value; }
        }
       
        public bool IsIncoming
        {
            get { return _isIncoming; }
            set { _isIncoming = value; }
        }
        
        public override string ToString()
        {
            return $"Letter\nNumber: {Number}\nDate: {Date}\nInformation: {Information}\nCorespondent: {Correspondent}\nIsIncoming: {IsIncoming}";
        }
        
       public override void Saving()
        {
            var documentObject = new
            {
                Number,
                Date,
                Correspondent,
                Information,
                IsIncoming
            };

            
            string json = JsonConvert.SerializeObject(documentObject, Formatting.Indented);

          
            string filePath = "Letter" + Number + ".json";
            File.WriteAllText(filePath, json);

        }
       
    }


}
