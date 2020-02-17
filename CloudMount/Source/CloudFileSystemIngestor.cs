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
                Console.WriteLine(bucket.Name);

            }
        }
    }
}
