using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase {
    public class ClaseVehiculo {
        private int cls_ID;

        public int Cls_ID {
            get {
                return cls_ID;
            }
            set {
                cls_ID = value;
            }
        }
        private string cls_descripcion;

        public string Cls_descripcion {
            get {
                return cls_descripcion;
            }
            set {
                cls_descripcion = value;
            }
        }
    }
}
