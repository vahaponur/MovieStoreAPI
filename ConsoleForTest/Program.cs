using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using System;

namespace ConsoleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IActorDal actorDal = new EfActorDal();
            Actor acc = actorDal.Get(c => c.Id == 1);
            ActorDetailDTO actorDetailDTO = actorDal.GetActorDetail(acc.Id);
            Console.WriteLine(actorDetailDTO.Movies[0]);
        }
    }
}
