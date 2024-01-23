using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using MySqlConnector;
using OBM_MovieApi.Context;
using OBM_MovieApi.Interfaces;

namespace OBM_MovieApi.Repository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    
    {
        public ActorRepository(MovieContext context) : base(context)
        {
        }

        public string GetTopnActorsForMovie(string MovieId, int actorsNeeded)
        {
            var movie = new MySqlParameter("p_MovieId", MovieId);
            var actorsRequired = new MySqlParameter("p_MovieId", MovieId);

            var result = _context.Actors.FromSql($"Call GetTopnActorsForMoview ({movie})"); // {actorsRequired})");

            var ActorsNameList = "";
            try
            {
                if (result.Any())
                {
                    var lastActor = result.Last();
                    foreach (var actor in result)
                    {
                        ActorsNameList += actor.ActorName;
                        if (!actor.Equals(lastActor))
                        {
                            ActorsNameList += ", ";
                        }

                    }
                }
            }
            catch (Exception)
            {

                return "No Actors Found";
            }

            
            

            return ActorsNameList;
        }
    }
}
