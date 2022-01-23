using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class MovieDetailDTO:IDto
    {
        public string MovieName { get; set; }
        public string[] Directors { get; set; }
        public string[] Actors { get; set; }
        public int GenreId { get; set; }
        public decimal Price { get; set; }
    }
}
