using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMount
{
    public class CloudFileSystem
    {
        private CloudFileSystemNode root;

        public CloudFileSystem()
        {
            root = new CloudFileSystemNode
            {
                AbsolutePath = "/",
                Name = "/",
                Type = CloudFileSystemNodeTypeEnum.ROOT
            };
        }
    }
}
