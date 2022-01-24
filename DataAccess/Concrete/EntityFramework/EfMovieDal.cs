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
    public class EfMovieDal : EfEntityRepositoryBase<Movie, MovieStoreContext>, IMovieDal
    {
        public MovieDetailDTO GetMovieDetail(int movieId)
        {
            using (var context = new MovieStoreContext())
            {
                MovieDetailDTO movieDetailDTO = new MovieDetailDTO();
                #region MapMovie
                var movie = context.Movies.SingleOrDefault(m => m.Id == movieId);
                movieDetailDTO.MovieName = movie.MovieName;
                #endregion

                #region MapGenre
                var genre = context.Genres.SingleOrDefault(g=>g.Id==movie.GenreId);
                movieDetailDTO.GenreName = genre.Name;
                #endregion

                #region MapDirectors
                var directorId = context.MoviesDirectors.Where(m => m.MovieId == movieId);
                foreach (var item in directorId)
                {
                    var director = context.Directors.SingleOrDefault(d=>d.Id==item.DirectorId);
                    movieDetailDTO.Directors.Add($"{director.FirstName} {director.LastName}");
                }
                #endregion

                #region MapActors
                var actorId = context.MoviesActors.Where(m => m.MovieId == movieId);
                foreach (var item in actorId)
                {
                    var actor = context.Actors.SingleOrDefault(d => d.Id == item.ActorId);
                    movieDetailDTO.Actors.Add($"{actor.FirstName} {actor.LastName}");
                }
                #endregion

                return movieDetailDTO;
            }

        }
    }
}
