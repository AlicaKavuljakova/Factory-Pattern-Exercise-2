using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products=new List<Product>()
        {
            new Product(){Name= "Mongo",Price=39.99 },
            new Product(){Name="MongoII",Price=149.99 },
            new Product(){Name= "MongoIII",Price=139.99 },
            new Product(){Name="MongoVI",Price=159.99 }
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I'm loading data from Mongo database");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a {GetType().Name} to database");
        }
    }
}
