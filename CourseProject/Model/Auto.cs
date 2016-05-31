using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Auto
    //Класс автомобиль
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int Distance { get; set; }
        public double Engine { get; set; }
        public byte Status { get; set; }
        public int ID { get; set; }
        public int SellerID { get; set; }

        public Auto(string brand, string model, string color, int price, int distance, double engine, byte status,  int sellerid, int id = 0)
        {
            ID = id;
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;
            Distance = distance;
            Engine = engine;
            Status = status;
            SellerID = sellerid;
        }
        public Auto():this(null,null,null,0,0,0,0,0) { }
        
    }
}
