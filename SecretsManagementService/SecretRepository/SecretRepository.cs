using System;
using System.Collections;
using System.Collections.Generic;

namespace SecretRepository 
{
    public class SecretRepository : ISecretRepository
    {
        private readonly Contexts.RepositoryContext _context;

        public SecretRepository(Contexts.RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Secret> List()
        {
            return _context.List();
        }
        public void Create(Models.Secret secret)
        {

        }
        public void Retrieve(Models.Secret secret){

        }
        public void RetrieveMetadata(Models.Secret secret)
        {

        }
        public void Update(Models.Secret secret)
        {

        }
        public void Delete(Models.Secret secret)
        {

        }

    }
}