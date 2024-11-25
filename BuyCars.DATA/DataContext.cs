using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA
{
    public class DataContext
    {
        public List<Car> cars { get; set; }
        public List<Castomer> castomers { get; set; }
        public List<Order> orders { get; set; }
        public DataContext()
        {
            cars = new List<Car> { new Car() { Id = 1, Company = "toyota", Price = 15000, status = true } };
            castomers = new List<Castomer> { new Castomer() { id = 1, name = "dan", phone = "0548562845" } };
            orders = new List<Order> { new Order() { Id = 1,car = new Car() { Id = 1,Company="toyota",Price=10000
            ,status = true },CastomerId=1,dateOfOrder=new DateTime() } };
        }
    }
}
