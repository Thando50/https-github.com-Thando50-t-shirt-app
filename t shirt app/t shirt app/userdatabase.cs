using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace t_shirt_app
{
    public class userdatabase
    { 

      private SQLiteConnection database;

      public userdatabase()
        {
            var path = GetDbPath();
            database = new SQLiteConnection(path);

            database.CreateTable<OrderingApp>();

            SeedDatabase();
        }

        public List<OrderingApp> GetItems()
        {
            return database.Table<OrderingApp>().ToList();
        }
        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "customerdetails.Db");
            return path;
        }
        public void SeedDatabase()
        {
            if (database.Table<OrderingApp>().Count() == 0)
            {

                OrderingApp newapp = new OrderingApp();

                newapp.Name = "thando";
                newapp.Gender = "male";
                newapp.TshirtSize = "medium";
                newapp.DateofTransaction = DateTime.Now;
                newapp.TshirtColor = "blue";
                newapp.ShipppingAddress = "bluedowns";

                database.Insert(newapp);
                


            }

            
        }

        public void addorder(string Name, string Gender, string TshirtSize, string TshirtColor, string ShipppingAddress)
        {
            OrderingApp temp = new OrderingApp();
            temp.Name = Name;
            temp.Gender = Gender;
            temp.TshirtSize = TshirtSize;
            temp.TshirtColor = TshirtColor;
            temp.ShipppingAddress = ShipppingAddress;


            database.Insert(temp);
        }
    }
}
