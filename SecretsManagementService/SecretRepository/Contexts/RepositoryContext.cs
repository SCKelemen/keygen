using System;
using System.Collections.Generic;
using System.Text;

namespace SecretRepository.Contexts
{
    public abstract class RepositoryContext : IRepositoryContext
    {   
        private string _identifier;
        public RepositoryContext(string identifier)
        {
            _identifier = identifier;
        }

        public string ContextIdentifier => _identifier;

        public abstract IEnumerable<Models.Secret> List();
        public abstract void Create(Models.Secret secret);
        public abstract void Retrieve(Models.Secret secret);
        public abstract void RetrieveMetadata(Models.Secret secret);
        public abstract void Update(Models.Secret secret);
        public abstract void Delete(Models.Secret secret);
        
    }
}
