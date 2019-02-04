using lin2db_column_mapping.Models;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lin2db_column_mapping.Components.Database
{
    public class DbContext : DataConnection
    {
        public DbContext(): base ("Default") { }

        public ITable<Product> Product => GetTable<Product>();
        

    }
}
