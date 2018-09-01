using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SecretRepository.Contexts
{
    public class AwsKmsContext : RepositoryContext
    {
        public AwsKmsContext() : base("AwsKmsContext")
        {

        }

        public override IEnumerable<Models.Secret> List()
        {
            return new List<Models.Secret>();
        }
        public override void Create(Models.Secret secret)
        {

        }
        public override void Retrieve(Models.Secret secret)
        {

        }
        public override void RetrieveMetadata(Models.Secret secret)
        {

        }
        public override void Update(Models.Secret secret)
        {

        }
        public override void Delete(Models.Secret secret)
        {

        }
    }
}
