using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] myShapes = { new Hexagon(), new Circle(), new Triangle(), new Circle("JoJo") };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                //Who's Pointy
                if (myShapes[i] is IPointy IP)
                    Console.WriteLine("-> Points: {0}", IP.Points);

                else
                    Console.WriteLine("-> {0}\'s not Pointy!", myShapes[i].petName);
                    
                

            }

            Console.ReadLine();
        }
    }
}
