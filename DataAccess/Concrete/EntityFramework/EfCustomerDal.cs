using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MovieStoreContext>, ICustomerDal
    {
        public CustomerProfileDTO GetCustomerDetailById(int customerId)
        {
            using (var context = new MovieStoreContext())
            {
                CustomerProfileDTO customerProfileDto = new CustomerProfileDTO();
                #region MapUser
                var customer = context.Users.SingleOrDefault(c => c.Id == customerId);
                customerProfileDto.FirstName = customer.FirstName;
                customerProfileDto.LastName = customer.LastName;
                #endregion

                #region MapFavMovies
                var movies = context.MoviesCustomers.Where(c => c.CustomerId == customerId).ToList();
                foreach (var item in movies)
                {
                    var movie = context.Movies.SingleOrDefault(m=>m.Id==item.MovieId);
                    customerProfileDto.BuyedMovies.Add(movie.MovieName);
                }
                #endregion

                #region MapGenres
                var genres = context.GenresCustomers.Where(c => c.CustomerId == customerId).ToList();
                foreach (var item in genres)
                {
                    var genre = context.Genres.SingleOrDefault(g => g.Id == item.GenreId);
                    customerProfileDto.FavoriteGenres.Add(genre.Name);
                }
                #endregion
                return customerProfileDto;
            }

        }
    }
}
