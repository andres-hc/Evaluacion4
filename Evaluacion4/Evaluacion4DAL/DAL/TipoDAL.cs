using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion4DAL.DAL
{
    public class TipoDAL
    {
        public Evaluacion4BDEntities1 dbEntities = new Evaluacion4BDEntities1();

        public List<Tipo> GetAll()
        {
            //Select*from Tipo
            return dbEntities.Tipo.ToList();
        }
    }
}
