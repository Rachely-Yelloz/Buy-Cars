using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class CastomerRepository:ICastomerRepository
    {
        private readonly DataContext _dataContext;

        public CastomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Castomer> getList()
        {
            return _dataContext.castomers;
        }
        public Castomer Get(int id)
        {
            foreach (Castomer castomer in _dataContext.castomers)
            {
                if(castomer.id==id)
                    return castomer;
            }
            return null;
        }
        public void Post( string name, string phone)
        {
            _dataContext.castomers.Add(new Castomer() { id=0, name=name, phone=phone });
        }
        public void Put(int id,string name, string phone)
        {

            for (int i = 0; i < _dataContext.castomers.Count; i++)
            {
                if (_dataContext.castomers[i].id == id)
                {
                    _dataContext.castomers[i].name = name;
                    _dataContext.castomers[i].phone = phone;
                    return;
                }
            }
        }
        public void PutOnlyPhone(int id, string phone)
        {
            for (int i = 0; i < _dataContext.castomers.Count; i++)
            {
                if (_dataContext.castomers[i].id == id)
                {
                    _dataContext.castomers[i].phone = phone;
                    return;
                }
            }
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _dataContext.castomers.Count; i++)
            {
                if (_dataContext.castomers[i].id == id)
                {
                    _dataContext.castomers.RemoveAt(i);
                    return;
                }

            }
        }
    }
}
