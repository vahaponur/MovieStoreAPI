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
    public class EfActorDal : EfEntityRepositoryBase<Actor, MovieStoreContext>,IActorDal
    {
        public ActorDetailDTO GetActorDetail(int actorId)
        {
            using (var context = new MovieStoreContext())
            {
                ActorDetailDTO actorDetailDTO = new ActorDetailDTO();
                #region MapActor
                var actor = context.Actors.SingleOrDefault(a => a.Id == id);
                actorDetailDTO.FirstName = actor.FirstName;
                actorDetailDTO.LastName = actor.LastName;
                #endregion

                #region MapMovies
                var movieIds = context.MoviesActors.Where(m => m.ActorId == id).ToList();
                foreach (var item in movieIds)
                {
                    var movie = context.Movies.SingleOrDefault(m => m.Id == item.MovieId);
                    actorDetailDTO.Movies.Add(movie.MovieName);
                }
                #endregion


                return actorDetailDTO;
            }
        }

    }
}
