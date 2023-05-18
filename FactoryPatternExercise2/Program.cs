using FactoryPatternExercise2;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            bool correct=false;
            string input;
            do { 
                Console.Clear();
                Console.WriteLine("your database");
                 input = Console.ReadLine().ToLower();
                if(input == "sql" || input == "sql" || input == "list")
                {
                    correct = true;
                }
            } while (!correct);
            Console.Clear();
                IDataAccess myData = DataAccessFactory.GetDataAccessType(input);
            
             var Products= myData.LoadData();
            myData.SaveData();
           foreach (var product in Products) { Console.WriteLine("Name: "+product.Name+ "   Price: "+product.Price); };

           
        }
    }
}
/*In one solution, you will need to create some new types.
A class called Product with 2 properties, Name and Price
An interface called IDataAccess with 2 methods, LoadData() and SaveData()
3 classes that implement the interface and its members (the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
Last you will need to create a class called DataAccessFactory
*/
/*The 3 classes that implement your IDataAccess interface should provide implementations for the 2 methods 
LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database}” and then return a new list of Product.
SaveData(): Print “I am saving data to a {whatever type} database” to the console*/

/*Lastly in the Main()
Ask the user what database they want to use: a List, SQL, or Mongo
Store their response in a variable
Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
Call the LoadData and SaveData methods of the IDataAccess variable
Run the program a few times using the different types.
*/