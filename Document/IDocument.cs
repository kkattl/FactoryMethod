using System;

namespace lab3.Document
{
    public interface IDocument
    {
        Guid Number { get;}
        string Date { get;}
        string Information { get;}
        void Saving();
    }
}
