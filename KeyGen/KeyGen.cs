using System;

namespace KeyGeneration 
{
public class KeyGenerator : IKeyGenerator
{
    private KeyGenerationStrategy _defaultStrategy;
    public Key GenerateKey()
    {
        return _defaultStrategy.GenerateKey();
    }
    public Key GenerateKey(KeyGenerationStrategy strategy)
    {
        return strategy.GenerateKey();
    }
}

public interface IKeyGenerator 
{
    Key GenerateKey();
    Key GenerateKey(KeyGenerationStrategy strategy);

}

public abstract class KeyGenerationStrategy
{
    private string _strategyIdentifier;

    public KeyGenerationStrategy(string strategyIdentifier)
    {
        _strategyIdentifier = strategyIdentifier;
    }
    public Key GenerateKey() 
    {
        throw new NotImplementedException();
    }
    public string StrategyIdentifier => _strategyIdentifier;
}

public class KeyPolicy 
{

}
public abstract class KeyBase 
{

}
public class Key 
{
    private int _id;
    private byte[] _value;
    public Key()
    {

    }

    public Key Previous
    {
        get;
    }

    public Key Next
    {
        get;
    }

    public string KeyGenerationStrategy 
    {
        get;
    }

    public int Id => _id;
    public byte[] Value => _value;
}


public class KeyImportStrategy
{
    PBKDF2Strategy strategy = new PBKDF2Strategy();
    public string Process() 
    {
        return strategy.StrategyIdentifier;
    }
}

public class PBKDF2Strategy : KeyGenerationStrategy
{
    //private string KeyGenerationStrategyIdentifier = "PBKDF2";
    public PBKDF2Strategy() : base("PBKDF2")
    {
        
    }

}

public interface IKeyVault
{

}

public abstract class KeyVault : IKeyVault
{

}

public class HashiCorpVault : KeyVault 
{
    
}
}