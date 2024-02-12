using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
    }

    public class MultifunctionPrinter : IMachine
    {
        public void Print(Document d)
        {
            Console.WriteLine("Print document.");
        }

        public void Scan(Document d)
        {
            Console.WriteLine("Scan document.");
        }
    }

    public class Printer : IMachine
    {
        public void Print(Document d)
        {
            Console.WriteLine("Print document.");
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException("Scan function is not supported.");
        }
    }

    public class Document
    {
    }

    public class ISPAssignment
    {
        public void Test()
        {
            IMachine printer = new Printer();
            printer.Print(new Document());
            printer.Scan(new Document()); //This causes problem, because printer can't scan. Make it so that printer can't scan.

            IMachine multifunctionPrinter = new MultifunctionPrinter();
            multifunctionPrinter.Print(new Document());
            multifunctionPrinter.Scan(new Document());
        }
    }
}
