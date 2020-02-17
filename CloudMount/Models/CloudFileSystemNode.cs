using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMount
{
    public class CloudFileSystemNode
    {
        public CloudFileSystemNodeTypeEnum Type { get; set; }
        public string Name { get; set; }
        public string AbsolutePath { get; set; }
        public CloudFileSystemNode Child { get; set; }
    }
}
