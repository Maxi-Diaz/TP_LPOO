using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Marca
    {
        private int mar_id;

        public int Mar_id
        {
            get { return mar_id; }
            set { mar_id = value; }
        }
        private string mar_descripcion;

        public string Mar_descripcion
        {
            get { return mar_descripcion; }
            set { mar_descripcion = value; }
        }
    }
}
