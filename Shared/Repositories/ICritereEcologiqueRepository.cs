using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Shared.Repositories
{
    public interface ICritereEcologiqueRepository<TEntity> 
    {
        IEnumerable<TEntity> Get();
    }
}
