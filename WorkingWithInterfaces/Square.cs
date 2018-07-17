using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInterfaces
{
    class Square : IShape
    {
        // Using explicit implementation to handle memeber name clash.
        void IPrintable.Draw()
        {
            // Draw to printer...
        }
        void IDrawable.Draw()
        {
            // Draw to screen...
        }
        public void Print()
        {
            // Print...
        }
        public int GetNumberOfSides()
        { return 4; }
    }
}
