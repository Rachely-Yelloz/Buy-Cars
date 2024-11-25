using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA.Repositories
{
    public class CarRepository:ICarRepository
    {
        private readonly DataContext _dataContext;

        public CarRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Car> getList()
        {
            return _dataContext.cars;
        }
      public  List<Car> GetSold()
        {
            List<Car> carNotAvialable = new List<Car>();
            foreach (var car in _dataContext.cars)
            {
                if (!car.status)
                    carNotAvialable.Add(car);
            }
            return carNotAvialable;
        }
        public Car GetById(int id)
        {
            foreach (var car in _dataContext.cars)
                if(car.Id==id)
                    return car;
            return null;
        }
        public List<Car> GetBycompany(string company)
        {
            List < Car > cars = new List<Car>();
            foreach (var car in _dataContext.cars)
                if (car.Company==company)
                    cars.Add(car);
            return cars;
        }
        public void Post(Car c)
        {
            _dataContext.cars.Add(c);
        }
        public void Put(int id,  string? company, double price)
        {
            for (int i = 0; i <_dataContext.cars.Count; i++)
            {
                if (_dataContext.cars[i].Id == id)
                {
                    if (company != null)
                        _dataContext.cars[i].Company = company;
                    _dataContext.cars[i].Price = price;
                }
            }
        }
    }
}
