using CapStone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone.DAL
{
    public interface IDataService
    {
        IEnumerable<Box> ReadAll();

    }
}
