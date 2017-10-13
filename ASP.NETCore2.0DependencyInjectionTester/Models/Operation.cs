using System;
using DependencyInjectionTester.Interfaces;

namespace DependencyInjectionTester.Models
{
    public class Operation : IOperationTransient, 
        IOperationScoped, 
        IOperationSingleton, 
        IOperationSingletonInstance
    {

        public static string GetName()
        {
            Random random = new Random();
            return "Operation Constructor" + random.Next(100).ToString() + " at : " + DateTime.Now.ToString();

        }

        public Operation():this(GetName())
        {
        }

        public Operation(string operationName)
        {
            OperationId = operationName;
        }

        public string OperationId { get; private set; }
    }
}