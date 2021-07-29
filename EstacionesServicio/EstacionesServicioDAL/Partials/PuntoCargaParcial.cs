using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesServicioDAL
{
    public partial class PuntoCarga
    {

        public string TipoTxt
        {
            get
            {
                string texto = "";
                switch (Tipo)
                {
                    case 1: texto = "Gasolina";
                        break;
                    case 2: texto = "Electrico";
                        break;
                    case 3: texto = "Hibrido";
                        break;
                }

                return texto;
            }
        }
    }
}
