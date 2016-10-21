using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryWithReflectionExampleComputers
{
    public class ComputerFactory
    {
        private static readonly IDictionary<string, Type> registeredTypes = new Dictionary<string, Type>();

        public static void Register<T>(string typeId)
        {
            var type = typeof(T);
            if (type.IsAbstract || type.IsInterface)
                throw new ArgumentException(
            "Cannot create abstract type " + type.Name);

            registeredTypes.Add(typeId, type);
        }

        public static T Create<T>(string id, params object[] parameters)
        {
            Type typeToCreate;
            if (!registeredTypes.TryGetValue(id, out typeToCreate))
                throw new NotSupportedException(
            "Type with id [" + id + "] is not registered.");

            return (T) Activator.CreateInstance(typeToCreate, parameters);
        }
    }
}