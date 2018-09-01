using System;
using System.Security.Cryptography;

namespace SecretsManagementService.KeyGeneration.Strategies
{
    public class RandomBytesStrategy : KeyGenerationStrategy
    {
        // RNGCryptoServiceProvider is not available in .NET Core
        private readonly RandomNumberGenerator _generator;
        public RandomBytesStrategy() : base("RandomBytesStrategy") 
        {
            _generator = RandomNumberGenerator.Create();
        }
        
        public new byte[] GenerateKey() 
        {
            return generateRandomBytes(16);
        }

        private byte[] generateRandomBytes(int size)
        {
            byte[] bytes = new byte[size];
            return generateRandomBytes(bytes);
        }
        private byte[] generateRandomBytes(byte[] bytes)
        {
            _generator.GetBytes(bytes);
            return bytes;
        }
         
    }
}