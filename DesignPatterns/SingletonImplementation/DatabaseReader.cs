using Microsoft.Extensions.Configuration;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingletonImplementation
{
    public class DatabaseReader : IDatabaseReader
    {
        private Dictionary<string, int> _countries = new Dictionary<string, int>();
        private DatabaseReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json");
            var configuration = builder.Build();

            _countries = File.ReadAllLines(configuration["filePath"])
                .Batch(2)
                .ToDictionary(
                l => l.ElementAt(0).Trim(),
                l => int.Parse(l.ElementAt(1).Trim()));
        }

        // Lazy loading. Only on accessing Value propery it will be initialized
        private static readonly Lazy<DatabaseReader> _instance = new Lazy<DatabaseReader>(() => new DatabaseReader());
        public static DatabaseReader Instance => _instance.Value;

        public int GetPopulation(string name)
        {
            return _countries[name];
        }
    }
}
