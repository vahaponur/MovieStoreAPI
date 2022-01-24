using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class CustomerProfileDTO:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> BuyedMovies { get; set; }
        public List<string> FavoriteGenres { get; set; }
    }
}
