using System;

namespace SecretsManagementService.Models
{
    public class Secret
    {
        public ulong SecretId { get; }
        public string SecretName { get; }
        public string SecretValue { get; }
        public DateTime Created { get; }

        public Secret(ulong secretId, string secretName, DateTime created, string value)
        {
            this.SecretId = secretId;
            this.SecretName = secretName;
            this.Created = created;
            this.SecretValue = value;
        }

        public Secret()
        {
            SecretId = 55;
            SecretName = "secret";
            SecretValue = "secret";
            Created = DateTime.Now;
        }
    }
}
