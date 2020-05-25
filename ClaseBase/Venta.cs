using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Venta
    {
        private int vta_Id;

        public int Vta_Id
        {
            get { return vta_Id; }
            set { vta_Id = value; }
        }
        private int cli_Id;

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        private int veh_Id;

        public int Veh_Id
        {
            get { return veh_Id; }
            set { veh_Id = value; }
        }
        private int usr_Id;

        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
        private DateTime vta_Fecha;

        public DateTime Vta_Fecha
        {
            get { return vta_Fecha; }
            set { vta_Fecha = value; }
        }
        private int pag_Id;

        public int Pag_Id
        {
            get { return pag_Id; }
            set { pag_Id = value; }
        }
        private decimal vta_PrecioFinal;

        public decimal Vta_PrecioFinal
        {
            get { return vta_PrecioFinal; }
            set { vta_PrecioFinal = value; }
        }
    }
}
