using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Paint2D
{
    public  interface IShape
    {
        string Name { get; }
        void HandleStart(double x, double y);
        void HandleEnd(double x, double y);

        UIElement Draw();
    }
}
