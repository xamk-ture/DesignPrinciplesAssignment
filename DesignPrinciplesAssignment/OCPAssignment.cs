using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{
    //Refactor this code to by using OCP principle
    public class Shape
    {
        public string Type { get; set; }

        public void Draw()
        {
            if (Type == "Circle")
            {
                DrawCircle();
            }
            else if (Type == "Square")
            {
                DrawSquare();
            }
        }

        private void DrawCircle()
        {
            Console.WriteLine("Drawing a circle.");
        }

        private void DrawSquare()
        {
            Console.WriteLine("Drawing a square.");
        }

        public void Test()
        {
            Shape circle = new Shape { Type = "Circle" };
            circle.Draw();

            Shape square = new Shape { Type = "Square" };
            square.Draw();
        }
    }
}
