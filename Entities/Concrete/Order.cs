using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderTime { get; set; }

    }
}
