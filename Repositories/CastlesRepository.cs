using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using knightsapi.Models;

namespace knightsapi.Repositories
{
    public class CastlesRepository
    {
        private readonly IDbConnection _db;
        public CastlesRepository(IDbConnection db){
            _db = db;
        }

        internal List<Castle> Get(){
            string sql = "SELECT * FROM castles";
            return _db.Query<Castle>(sql).ToList();
        }

        internal Castle Get(int id){
            string sql = "SELECT * FROM castles WHERE id = @id";
            return _db.QueryFirstOrDefault<Castle>(sql, new {id});
        }

        internal Castle Create(Castle newCastle){
            string sql = @"
            INSERT INTO castles
            (name)
            VALUES
            (@Name);
            SELECT LAST_INSERT_ID();";
            newCastle.Id = _db.ExecuteScalar<int>(sql, newCastle);
            return this.Get(newCastle.Id);
        }

        internal Castle Update(Castle updatedCastle){
            string sql = @"
            UPDATE castles
            SET
                name = @Name
            WHERE id = @Id;";
            _db.Execute(sql, updatedCastle);
            return updatedCastle;
        }
    }
}