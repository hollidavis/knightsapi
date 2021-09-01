using System.Data;

namespace knightsapi.Repositories
{
    public class CastlesRepository
    {
        private readonly IDbConnection _db;
        public CastlesRepository(IDbConnection db){
            _db = db;
        }

        internal List<Castle>
    }
}