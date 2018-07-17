using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface Name Clashes
            //Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            //Octagon oct = new Octagon();

            //// We now must use casting to access the Draw() members
            //IDrawToForm itfForm = (IDrawToForm)oct;
            //itfForm.Draw();

            //// Shorthand notation if you don't need the interface variable for later use.
            //((IDrawToPrinter)oct).Draw();

            //// Could also use the "as" keyword.
            //if (oct is IDrawToMemory)
            //    ((IDrawToMemory)oct).Draw();

            //Console.ReadLine();
            #endregion

            #region Interface Hierarchy
            Console.WriteLine("***** Simple Interface Hierarchy *****");

            // Call from object level.
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            // Get IAdvancedDraw explicitly.
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();

            Console.ReadLine();
            #endregion
        }

        
    }
}
