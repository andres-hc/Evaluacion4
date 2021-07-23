using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesServicioDAL.DAL
{
    public class PuntoCargaDAL
    {

        EstacionesServicioBDEntities dbEntities = new EstacionesServicioBDEntities();
        PuntoCargaDAL puntoCargaDAL = new PuntoCargaDAL();

        public void Add(PuntoCarga p)
        {
            dbEntities.PuntoCarga.Add(p);
            dbEntities.SaveChanges();
        }

        public List<PuntoCarga> GetAll()
        {
            return dbEntities.PuntoCarga.ToList();
        }

        //buscar puntos por id
        public PuntoCarga buscarPunto(int idPunto)
        {
            return dbEntities.PuntoCarga.Find(idPunto);
        }

        //Filtrar por tipo
        public List<PuntoCarga> GetAll(int tipo)
        {
            //LINQ
            var query = from c in dbEntities.PuntoCarga
                        where c.Tipo == tipo
                        select c;
            return query.ToList();

        }

        
    }
}
