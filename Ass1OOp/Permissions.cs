using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    internal enum Permissions
    {
        Write=1, Read = 2, Execute = 4, Delete = 8
    }
}
