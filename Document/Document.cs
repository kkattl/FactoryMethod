using System;


namespace lab3.Document
{
    public abstract class Document : IDocument
    {
      
        protected readonly Guid _number;
        protected readonly string _date;
        protected string _info;

        public Document()
        {
            _number = Guid.NewGuid();
            _date = DateTime.Now.ToString("yyyyMMdd");
            _info = Information;
        }

        public Guid Number => _number;
        public string Date => _date;
        public string Information
        {
            get { return _info; }
            set { _info = value; }
        }
        public abstract void Saving();
       
      
    }

}
