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
        public List<string> Directors { get; set; }
        public List<string> Actors { get; set; }
        public string GenreName { get; set; }
        public decimal Price { get; set; }
        public MovieDetailDTO()
        {
            Directors = new List<string>();
            Actors = new List<string>();
        }
    }
}
