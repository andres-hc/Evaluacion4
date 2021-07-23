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
    public partial class MostrarEstaciones : System.Web.UI.Page
    {
        EstacionServicioDAL estacionServicioDAL = new EstacionServicioDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estacionServicioDAL.GetAll());
            }
        }

        public void CargarTabla(List<EstacionServicio> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind();
        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                string idEliminar = e.CommandArgument.ToString();
                estacionServicioDAL.Remove(Convert.ToInt32(idEliminar));
                CargarTabla(estacionServicioDAL.GetAll());
            }
        }
    }
}