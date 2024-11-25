using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Models
{
    public class Order
    {
        public int Id { get;  set; }
        public DateTime dateOfOrder { get; set; }
        public int CastomerId { get; set; }
        public Car car { get; set; }
    }
}
