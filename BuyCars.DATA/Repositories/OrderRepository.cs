using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> getList()
        {
            return _dataContext.orders.ToList();
        }
        public Order Get(int id)
        {
            foreach (var item in _dataContext.orders.ToList()) { if (item.Id == id) return item; }
            return null;
        }
        public List<Order> Getbyid(int idofper)
        {
            List<Order> l = new List<Order>();
            foreach (var item in _dataContext.orders.ToList()) { if (item.CastomerId == idofper) l.Add(item); }
            return l;
        }
        public void Post(DateTime dateOfOrder, int castomerId, Car c)
        {
            _dataContext.orders .Add(new Order() { dateOfOrder = dateOfOrder, CastomerId = castomerId, car = c });
        }
        public void Put(int id, DateTime d)
        {

            for (int i = 0; i < _dataContext.orders.ToList().Count; i++)
            {
                if (_dataContext.orders.ToList()[i].Id == id)
                {
                    _dataContext.orders.ToList()[i].dateOfOrder = d;
                }
            }
        }
        public void Delete(int id)
        {

            for (int i = 0; i < _dataContext.orders.ToList().Count; i++)
            {
                if (_dataContext.orders.ToList()[i].Id == id) { _dataContext.orders.ToList().RemoveAt(i); }
            }
        }
    }
}
