using MyFirstWinformApp.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.Models
{
    public class Car
    {
        public Iuser User { get; set; }
        public Car()   //要有一个空的，默认的
        {
            
        }
        public Car(Iuser user)
        {
            User = user;
        }
        public string Color { get; set; } = "red";
        public int Length { get; set; }
        public string Description { get; set; }
        public void Run() 
        {
            MessageBox.Show($"{User.UserName} kai che l!!");
        }
    }

    public class Truck: Car
    {
        public Truck()   //要有一个空的，默认的
        {
            
        }
        public Truck(Iuser user) : base(user)
        {

        }

        public required string Carriage { get; set; }
        new public string Color { get; set; } = "bule";
        public string Freight()
        {
            return$"chang{Length}{Color}dechezaiyunshu{Carriage}";
        }
    }
    public class SUV: Car
    {

        public SUV()  //要有一个空的，默认的
        {
            
        }
        public SUV(Iuser user):base(user)
        {
            
        }

        public required string Carriage { get; set; }
        new public string Color { get; set; } = "bule";
        public int Seat {  get; set; }
        public string Freight()
        {
            return$"chang{Length}{Color}dechezaiyunshu{Carriage}";
        }
    }
  
}
