using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace t_shirt_app
{
    public class OrderingApp
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        public string Name
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }
        public string TshirtSize
        {
            get;
            set;
        }

        public DateTime DateofTransaction
        {
            get;
            set;
        }

        public string TshirtColor
        {
            get;
            set;
        }

        public string ShipppingAddress
        {
            get;
            set;
        }
        

    }
}

    

