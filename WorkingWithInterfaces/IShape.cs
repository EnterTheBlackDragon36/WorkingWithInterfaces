using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInterfaces
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
