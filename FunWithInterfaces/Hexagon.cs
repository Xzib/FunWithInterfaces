using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    public class Hexagon:Shapes, IPointy
    {

        public Hexagon() { }
        public Hexagon(String name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Hexagon");
        }

        public byte Points
        {
            get { return 6; }
        }
    }
}
