using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Linea
    {
        private int lin_id;

        public int Lin_id
        {
            get { return lin_id; }
            set { lin_id = value; }
        }
        private string lin_descripcion;

        public string Lin_descripcion
        {
            get { return lin_descripcion; }
            set { lin_descripcion = value; }
        }
        private int mar_id;

        public int Mar_id
        {
            get { return mar_id; }
            set { mar_id = value; }
        }
    }
}
