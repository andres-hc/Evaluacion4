using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesServicioDAL.DAL
{
    public class PuntoCargaDAL
    {

        public EstacionesServicioBDEntities dbEntities = new EstacionesServicioBDEntities();

        public void Add(PuntoCarga p)
        {
            dbEntities.PuntoCarga.Add(p);
            dbEntities.SaveChanges();
        }

        public List<PuntoCarga> GetAll()
        {
            return dbEntities.PuntoCarga.ToList();
        }

        public List<PuntoCarga> GetAll(int tipo)
        {
            var query = from p in dbEntities.PuntoCarga
                        where p.Tipo == tipo
                        select p;
            return query.ToList();
        }

        //buscar punto
        public PuntoCarga buscarPunto(int idPunto)
        {
            return dbEntities.PuntoCarga.Find(idPunto);
        }

        //actualizar punto
        public int actualizarPunto(PuntoCarga nuevoPto)
        {
            PuntoCarga p = dbEntities.PuntoCarga.Find(nuevoPto.IdPunto);
            p = nuevoPto;
            return dbEntities.SaveChanges();
        }
    }
}
