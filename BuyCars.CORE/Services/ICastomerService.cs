﻿using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Services
{
    public interface ICastomerService
    {
        List<Castomer> GetList();
        Castomer Get(int id);
         void Post(string name, string phone);
        void Put(int id, string name, string phone);
        void PutOnlyPhone(int id, string phone);
        void Delete(int id);
    }
}
