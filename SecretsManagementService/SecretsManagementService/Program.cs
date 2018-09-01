using System;
using System.Collections.Generic;

namespace SecretsManagementService
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.Secret item = new Models.Secret();
            ItemProcessor processor = new ItemProcessor();
            Models.Secret item2 = processor.Process(item);
            IReadOnlyCollection<string> readonlyCollection = new List<string>();
            Console.ReadKey();
        }
    }

    class ItemProcessor : ProcessorBase<Models.Secret>
    {
        public new Models.Secret Process(Models.Secret item)
        {
            return new Models.Secret(item.SecretId, item.SecretName, item.Created, item.SecretValue + 1);
        }
    }

    public abstract class ProcessorBase<T> : IProcessor<T>
    {
        public virtual T Process(T item)
        {
            Console.WriteLine($"{item.GetType()} Item processed.");
            return item;
        }
    }   

    interface IProcessor<T>
    {
        T Process(T item);
    }

    interface INode
    {
        INode Next();
    }
}