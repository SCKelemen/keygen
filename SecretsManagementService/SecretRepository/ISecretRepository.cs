using System;
using System.Collections;
using System.Collections.Generic;

namespace SecretRepository 
{
    public interface ISecretRepository 
    {
        IEnumerable<Models.Secret> List();
        void Create(Models.Secret secret);
        void Retrieve(Models.Secret secret);
        void RetrieveMetadata(Models.Secret secret);
        void Update(Models.Secret secret);
        void Delete(Models.Secret secret);

    }
}