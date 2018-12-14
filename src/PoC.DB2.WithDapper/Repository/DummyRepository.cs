using System.Collections.Generic;
using System.Data;
using Dapper;
using IBM.Data.DB2.Core;
using PoC.DB2.WithDapper.Model;

namespace PoC.DB2.WithDapper.Repository
{
    /// <summary>
    /// Implements interface for get some dummy data.
    /// 
    /// You just need to change data that you are querying.
    /// </summary>
    public class DummyRepository : IDummyRepository
    {
        private readonly IDbConnection db;

        public DummyRepository(string strConnection)
        {
            db = new DB2Connection(strConnection);
        }
        
        public IList<DummyModel> GetDummyData(string param1, string param2)
        {
            return db.Query<DummyModel>(QueryDummyData, new { PARAM1 = param1, PARAM2 = param2 }).AsList();
        }

        private string QueryDummyData 
        {
            get 
            {
                return "SELECT * FROM TABLE WHERE SOMETHING = @PARAM1 AND ANOTHERSOMETHING = @PARAM2";
            }
        }
    }
}