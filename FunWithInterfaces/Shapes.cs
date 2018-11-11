using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    abstract public class Shapes
    {



        #region Public properties
        /// <summary>
        /// Private property
        /// </summary>

        public string petName {
            get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name"></param>
        public Shapes(string name = "NoName")
        {
            petName = name;
        }
        #endregion

        #region VirtualMethods
        /// <summary>
        /// Virtual method for overriding by children
        /// 
        /// this method is not neccessary for the child classes to use because it is not declared as abstract method
        /// </summary>
        /*
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shapes.Draw()");
        }
        */
        #endregion


        #region AbstractMethod
        /// <summary>
        /// This Method must be overriden by children classes, because it has been declared as abstract 
        /// if they donot override this method they will also be considered as an abstract class and should be 
        /// defined with abstract keyword at 
        /// </summary>

        public abstract void Draw();
        #endregion




    }
}
