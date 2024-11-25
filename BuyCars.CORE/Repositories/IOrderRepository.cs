﻿using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Repositories
{
    public interface IOrderRepository
    {
        List<Order> getList();
       Order Get(int id);
        List<Order> Getbyid(int idofper);
        void Post(DateTime dateOfOrder, int castomerId, Car c);
        void Put(int id, DateTime d);
         void Delete(int id);
    }
}
