using System;

namespace SecretsManagementService.KeyGeneration.Strategies
{
    public abstract class KeyGenerationStrategy
    {
         private string _strategyIdentifier;

        public KeyGenerationStrategy(string strategyIdentifier)
        {
            _strategyIdentifier = strategyIdentifier;
        }
        public byte[] GenerateKey() 
        {
            throw new NotImplementedException();
        }
        public string StrategyIdentifier => _strategyIdentifier;
    }
}