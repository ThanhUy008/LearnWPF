using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    interface IShapeToStringConverter
    {
        string Convert(IShape shape);
        IShape ConvertBack(string buffer);
    }
}
