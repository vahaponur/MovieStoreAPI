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
    public class EfDirectorDal : EfEntityRepositoryBase<Director, MovieStoreContext>, IDirectorDal
    {
        public DirectorDetailDTO GetDirectorDetail(int directorId)
        {
            using (var context = new MovieStoreContext())
            {
                DirectorDetailDTO directorDetailDTO = new DirectorDetailDTO();

                #region MapDirector
                var director = context.Directors.SingleOrDefault(d => d.Id == directorId);
                directorDetailDTO.FirstName = director.FirstName;
                directorDetailDTO.LastName = director.LastName;
                #endregion

                #region MapMovies
                var movieIds = context.MoviesDirectors.Where(d => d.DirectorId == directorId).ToList();
                foreach (var item in movieIds)
                {
                    var movie = context.Movies.SingleOrDefault(m => m.Id == item.MovieId);
                    directorDetailDTO.Movies.Add(movie.MovieName);
                }
                #endregion

                return directorDetailDTO;
            }
        }
    }
}
