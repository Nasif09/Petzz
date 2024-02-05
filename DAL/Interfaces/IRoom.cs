using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRoom<CLASS, ID, UID, Ret>
    {
        List<CLASS> GetByID(ID id, UID UIU);
    }
}
