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
    public partial class MostrarPuntos : System.Web.UI.Page
    {
        PuntoCargaDAL puntoCargaDAL = new PuntoCargaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void CargarTabla(List<PuntoCarga> puntos)
        {
            puntosGrid.DataSource = puntos;
            puntosGrid.DataBind();
        }

        protected void tipoDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSlct = tipoDd.SelectedValue;
            if (tipoDd.SelectedValue == "")
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
            else
            {
                List<PuntoCarga> filtro = puntoCargaDAL.GetAll(Convert.ToInt32(tipoSlct));
                CargarTabla(filtro);
            }
        }
    }
}