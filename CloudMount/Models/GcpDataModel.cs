using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudMount
{
    public class GcpDataModel
    {
        public string credentialsFilePath { get; set; }
        public string projectId { get; set; }
        public StorageClient client { get; set; }
    }
}
