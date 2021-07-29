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
    public partial class EditarPuntos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                List<PuntoCarga> puntos = new PuntoCargaDAL().GetAll();
                idDdw.DataSource = puntos;
                idDdw.DataTextField = "IdPunto";
                idDdw.DataValueField = "IdPunto";
                idDdw.DataBind();

                List<Tipo> tipo = new TipoDAL().GetAll();
                tipoDdw.DataSource = tipo;
                tipoDdw.DataTextField = "Nombre";
                tipoDdw.DataValueField = "IdTipo";
                tipoDdw.DataBind();
            }

        }

        protected void editarPtoBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                PuntoCargaDAL puntoCarga = new PuntoCargaDAL();
                //buscador
                int id = Convert.ToInt32(idDdw.SelectedValue);
                //ediciones
                int tipo = Convert.ToInt32(tipoDdw.SelectedValue);
                int capacidad = Convert.ToInt32(capacidadTxt.Text);
                DateTime fecha = Convert.ToDateTime(fechaTxt.Text);


                PuntoCarga p = puntoCarga.buscarPunto(id);
                p.Tipo = tipo;
                p.Capacidad = capacidad;
                p.FechaVencimiento = fecha;

                puntoCarga.actualizarPunto(p);

                confirmacion.Text = "Edicion correcta.";


            }
        }
    }
}