using System;
using System.Threading.Tasks;

namespace DataAccess.Dao
{
    public interface ISecretService : IDisposable
    {
        Task CreateSecretAsync(ulong secretId, string secretName);
        Task<Models.Secret> GetSecretAsync(ulong secretId);
        Task DeleteSecretAsync(ulong secretId);
    }
}
