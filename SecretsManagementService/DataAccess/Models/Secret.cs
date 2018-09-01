using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Secret
    {
        public ulong SecretId { get; }
        public string SecretName { get; }
        public DateTime Created { get; }

        public Secret (  ulong secretId, string secretName, DateTime created )
        {
            this.SecretId = secretId;
            this.SecretName = secretName;
            this.Created = created;
        }
    }
}
