using System;

using Microsoft.Extensions.Configuration;

namespace TurttleChallenge.Configurations
{
    public class Configuration<T> 
        where T : class
    {
        public static T Load(string fileName)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(fileName)
                .Build();

            var settings = config.Get<T>();

            return settings;
        }
    }
}
