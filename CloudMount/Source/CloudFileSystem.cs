using System.Collections.Generic;

namespace CloudMount
{
    public class CloudFileSystem
    {
        private CloudFileSystemNode root;

        public CloudFileSystem()
        {
            string prefix = "cloud://";
            root = new CloudFileSystemNode
            {
                AbsolutePath = prefix,
                Name = prefix,
                Type = CloudFileSystemNodeTypeEnum.ROOT
            };
        }

        // Should only be used externally for inserting buckets onto root
        public void AddChild(CloudFileSystemNode parent, CloudFileSystemNode child)
        {
            if (parent.Children == null)
            {
                parent.Children = new List<CloudFileSystemNode>();
            }

            parent.Children.Add(child);
        }

        // Create file in FS by automatically finding the correct node to place under.
        // If directories do not exist in path to file, create them and manage nodes.
        public void AddFileWithAbsolutePath(string path)
        {
            // TODO
        }

        public CloudFileSystemNode GetRootNode()
        {
            return root;
        }
    }
}
