using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name= "SQL",Price=39.99 },
            new Product(){Name="SQLII",Price=149.99 },
            new Product(){Name= "SQLIII",Price=139.99 },
            new Product(){Name="SQLVI",Price=159.99 }
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading SQL database...");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a {GetType().Name} to database");
        }
    }
}
