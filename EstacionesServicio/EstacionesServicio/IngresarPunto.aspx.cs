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
    public partial class IngresarPunto : System.Web.UI.Page
    {
        PuntoCargaDAL puntocargaDAL = new PuntoCargaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Tipo> tipos = new TipoDAL().GetAll();
                tipoDdw.DataSource = tipos;
                tipoDdw.DataTextField = "Nombre";
                tipoDdw.DataValueField = "IdTipo";
                tipoDdw.DataBind();
            }
        }

        protected void registrarPtoBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idPuntoTxt.Text);
                int capacidad = Convert.ToInt32(capacidadTxt.Text);
                int tipo = Convert.ToInt32(tipoDdw.SelectedValue);
                DateTime fecha = Convert.ToDateTime(fechaTxt.Text);

                if(puntocargaDAL.buscarPunto(id) == null)
                {
                    PuntoCarga punto = new PuntoCarga();
                    punto.IdPunto = id;
                    punto.Capacidad = capacidad;
                    punto.Tipo = tipo;
                    punto.FechaVencimiento = fecha;

                    new PuntoCargaDAL().Add(punto);

                    confirmacion.Text = "Registro ingresado correctamente.";
                }
                else
                {
                    confirmacion.Text = "ID ya existe, reingrese";
                }

                

            }
        }
    }
}