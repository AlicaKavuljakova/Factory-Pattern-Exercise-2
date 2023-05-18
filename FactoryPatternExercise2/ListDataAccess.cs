using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
  public class ListDataAccess : IDataAccess
 {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name= "List",Price=39.99 },
            new Product(){Name="ListII",Price=149.99 },
            new Product(){Name= "ListIII",Price=139.99 },
            new Product(){Name="ListVI",Price=159.99 }
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading List database...");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a { GetType().Name} to database" );
        }
    }
}
