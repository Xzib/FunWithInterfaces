using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    class Triangle : Shapes, IPointy
    {
        public Triangle() { }
        public Triangle(String name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Trianlge", petName);
        }

        //Ipointy Implementation

        public byte Points
        {
            get  { return 3; }
        }
      



    }
}