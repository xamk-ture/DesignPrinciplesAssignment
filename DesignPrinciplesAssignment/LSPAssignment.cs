using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{
    //Refactor this code to by using LSP principle
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    public class Duck : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Duck is flying.");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly.");
        }
    }

    class LspTest
    {
        static void Test()
        {
            Bird duck = new Duck();
            duck.Fly();

            Bird penguin = new Penguin();
            penguin.Fly(); //This causes problem, beacuse penguings can't fly
        }
    }
}
