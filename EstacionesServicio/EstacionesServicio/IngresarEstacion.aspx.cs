using EstacionesServicioDAL;
using EstacionesServicioDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionesServicio
{
    public partial class IngresarEstacion : System.Web.UI.Page
    {
        EstacionServicioDAL estacionServicioDAl = new EstacionServicioDAL();
        EstacionesServicioBDEntities dbEntities = new EstacionesServicioBDEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrarEstacion_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idEstacionTxt.Text);
                int capacidad = Convert.ToInt32(capacidadTxt.Text);

                EstacionServicio es = new EstacionServicio();

                es.IdEstacion = id;
                es.Capacidad = capacidad;

                new EstacionServicioDAL().Add(es);

                confirmacion.Text = "Registro creado";

            }
        }
    }
}