using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMount
{
    public enum CloudFileSystemNodeTypeEnum
    {
        NONE = 0,
        ROOT = 1,
        BUCKET = 2,
        DIRECTORY = 3,
        FILE = 4
    }
}
