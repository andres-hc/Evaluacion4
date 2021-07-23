using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesServicioDAL.DAL
{
    public class EstacionServicioDAL
    {
        public EstacionesServicioBDEntities dbEntities = new EstacionesServicioBDEntities();

        public void Add(EstacionServicio es)
        {
            dbEntities.EstacionServicio.Add(es);
            dbEntities.SaveChanges();
        }

        public List<EstacionServicio> GetAll()
        {
            //select * from clientes
            return dbEntities.EstacionServicio.ToList();
        }

        public void Remove(int idEstacion)
        {
            EstacionServicio es = dbEntities.EstacionServicio.Find(idEstacion);
            dbEntities.EstacionServicio.Remove(es);
            dbEntities.SaveChanges();
        }

        //Buscar estaciones por id
        public EstacionServicio buscarEstacion(int idEstacion)
        {
            return dbEntities.EstacionServicio.Find(idEstacion);
        }

        //public void Remove2(int nivel)
        //{
        //    //LINQ Lenguaje de consultas para EF basado en objetos (SQL de Objetos)

        //    //Buscar el cliente que quiero borrar
        //    var query = from c in dbEntities.Cliente
        //                where c.Nivel == nivel
        //                select c;

        //    foreach (var c in query)
        //    {
        //        dbEntities.Cliente.Remove(c);
        //        dbEntities.SaveChanges();
        //    }

        //}

        //public List<Cliente> GetAll(int nivel)
        //{
        //    //LINQ
        //    var query = from c in dbEntities.Cliente
        //                where c.Nivel == nivel
        //                select c;
        //    return query.ToList();

        //}



    }
}
