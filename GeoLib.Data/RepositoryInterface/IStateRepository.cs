using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoLib.Core;
using GeoLib.Data.Entities;

namespace GeoLib.Data.RepositoryInterface
{
    public interface IStateRepository : IDataRepository<State>
    {
        State Get(string abbrev);
        IEnumerable<State> Get(bool primaryOnly);
    }
}
