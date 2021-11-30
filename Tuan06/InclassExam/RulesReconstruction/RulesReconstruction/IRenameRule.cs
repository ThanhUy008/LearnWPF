using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesReconstruction
{
    interface IRenameRule
    {
        string Rename(string original);
    }
}
