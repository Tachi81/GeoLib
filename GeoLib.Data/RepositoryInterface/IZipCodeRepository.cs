using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoLib.Core;
using GeoLib.Data.Entities;

namespace GeoLib.Data.RepositoryInterface
{
    public interface IZipCodeRepository : IDataRepository
    {
        ZipCode GetByZip(string zip);
        IEnumerable<ZipCode> GetByState(string state);
        IEnumerable<ZipCode> GetZipsForRange(ZipCode zip, int range);
    }
}
