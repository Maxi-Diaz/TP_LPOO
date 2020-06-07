using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class FormaPago
    {
        private int pag_id;

        public int Pag_id
        {
            get { return pag_id; }
            set { pag_id = value; }
        }
        private string pag_descripcion;

        public string Pag_descripcion
        {
            get { return pag_descripcion; }
            set { pag_descripcion = value; }
        }
    }
}
