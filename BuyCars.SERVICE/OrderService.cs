﻿using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using BuyCars.CORE.Services;
using BuyCars.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.SERVICE
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }
        public List<Order> GetList()
        {
            return _OrderRepository.getList();
        }
        public Order Get(int id)
        {
            return _OrderRepository.Get(id);
        }
        public List<Order> Getbyid(int idofper)
        {
            return _OrderRepository.Getbyid(idofper);
        }
        public void Post(DateTime dateOfOrder, int castomerId, Car c)
        {
            _OrderRepository.Post(dateOfOrder, castomerId, c);
        }
        public void Put(int id, DateTime d)
        {
            _OrderRepository.Put(id, d);
        }
        public void Delete(int id) { 
        _OrderRepository.Delete(id);
        }


}
}
