using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lin2db_column_mapping.Models
{
    [Table(Name = "products")]
    public class Product
    {
        [Identity, PrimaryKey]
        public int ID { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Description { get; set; }
        [Column]
        public DateTime DateCreated { get; set; }
    }
}
