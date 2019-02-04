using LinqToDB;
using LinqToDB.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lin2db_column_mapping.Components.Database
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class CustomConnectionStrings : ILinqToDBSettings
    {
        private readonly IConfiguration configuration;

        public CustomConnectionStrings(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => ProviderName.MySql;
        public string DefaultDataProvider => ProviderName.MySql;

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Default",
                        ProviderName = ProviderName.MySql,
                        ConnectionString = configuration.GetConnectionString("mysql")
                    };
            }
        }
    }
}
