using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class TipoVehiculo
    {
        private int tip_id;

        public int Tip_id
        {
            get { return tip_id; }
            set { tip_id = value; }
        }
        private string tip_descripcion;

        public string Tip_descripcion
        {
            get { return tip_descripcion; }
            set { tip_descripcion = value; }
        }
    }
}
