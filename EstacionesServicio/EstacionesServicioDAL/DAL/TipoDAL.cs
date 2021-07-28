using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesServicioDAL.DAL
{
    public class TipoDAL
    {

        public EstacionesServicioBDEntities dbEntities = new EstacionesServicioBDEntities();

        public List<Tipo> GetAll()
        {
            return dbEntities.Tipo.ToList();
        }

    }
}
