using ModelLibrary;

namespace OBM_MovieApi.Interfaces
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        public string GetTopnActorsForMovie(string MovieId, int actorsNeeded);
    
    }
}
