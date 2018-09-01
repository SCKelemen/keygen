using System;
using System.Collections.Generic;
using System.Text;

namespace SecretRepository.Contexts
{
    public interface IRepositoryContext
    {
        IEnumerable<Models.Secret> List();
        void Create(Models.Secret secret);
        void Retrieve(Models.Secret secret);
        void RetrieveMetadata(Models.Secret secret);
        void Update(Models.Secret secret);
        void Delete(Models.Secret secret);
    }
}
