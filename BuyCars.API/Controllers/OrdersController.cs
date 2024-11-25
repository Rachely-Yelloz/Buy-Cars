using BuyCars.CORE.Models;
using BuyCars.CORE.Services;
using BuyCars.SERVICE;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuyCars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _ordersService;

        public OrdersController(IOrderService ordersService)
        {
            _ordersService = ordersService;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _ordersService.GetList();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _ordersService.Get(id);
        }

        // POST api/<OrdersController>
        [HttpGet("customer/{idofper}")]
        public List<Order> Getbyid(int idofper)
        {
            return _ordersService.Getbyid(idofper);
        }

        // PUT api/<OrdersController>/5
        [HttpPost]
        public void Post(DateTime dateOfOrder, int castomerId, Car c)
        {
            _ordersService.Post(dateOfOrder, castomerId, c);
        }
        [HttpPut("{id}")]
        public void Put(int id, DateTime d)
        {
            _ordersService.Put(id, d);
        }
        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ordersService.Delete(id);
        }
    }
}
