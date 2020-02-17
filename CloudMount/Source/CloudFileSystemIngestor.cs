using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMount
{
    public class CloudFileSystemIngestor
    {
        public static void IngestGcp(CloudFileSystem fs, GcpDataModel gcp)
        {
            var buckets = gcp.client.ListBuckets(gcp.projectId);
            foreach (var bucket in buckets)
            {
                var root = fs.GetRootNode();
                var child = new CloudFileSystemNode
                {
                    Name = bucket.Name,
                    AbsolutePath = String.Format("{0}{1}", root.AbsolutePath, bucket.Name),
                    Type = CloudFileSystemNodeTypeEnum.BUCKET
                };
                fs.AddChild(root, child);

                foreach (var file in gcp.client.ListObjects(child.Name))
                {
                    fs.AddFileWithAbsolutePath(file.Name);
                }
            }
        }
    }
}
