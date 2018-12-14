using System.Collections.Generic;
using PoC.DB2.WithDapper.Model;

namespace PoC.DB2.WithDapper.Repository
{
    public interface IDummyRepository
    {
        /// <summary>
        /// Get something. For now just dummy data.
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        IList<DummyModel> GetDummyData(string param1, string param2); // maybe I change it later.
    }
}