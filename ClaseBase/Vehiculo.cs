using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Vehiculo
    {
        private string veh_Matricula;

        public string Veh_Matricula
        {
            get { return veh_Matricula; }
            set { veh_Matricula = value; }
        }
        private string veh_Marca;

        public string Veh_Marca
        {
            get { return veh_Marca; }
            set { veh_Marca = value; }
        }
        private int lin_Id;

        public int Lin_Id
        {
            get { return lin_Id; }
            set { lin_Id = value; }
        }
        private int veh_Modelo;

        public int Veh_Modelo
        {
            get { return veh_Modelo; }
            set { veh_Modelo = value; }
        }
        private string veh_Color;

        public string Veh_Color
        {
            get { return veh_Color; }
            set { veh_Color = value; }
        }
        private int veh_Puerta;

        public int Veh_Puerta
        {
            get { return veh_Puerta; }
            set { veh_Puerta = value; }
        }
        private Boolean veh_GPS;

        public Boolean Veh_GPS
        {
            get { return veh_GPS; }
            set { veh_GPS = value; }
        }
        private int tip_ID;

        public int Tip_ID {
            get {
                return tip_ID;
            }
            set {
                tip_ID = value;
            }
        }
        private int cls_ID;

        public int Cls_ID {
            get {
                return cls_ID;
            }
            set {
                cls_ID = value;
            }
        }
        private decimal veh_Precio;

        public decimal Veh_Precio
        {
            get { return veh_Precio; }
            set { veh_Precio = value; }
        }

     
        private int veh_ID;

        public int Veh_ID {
            get { return veh_ID; }
            set { veh_ID = value; }
        }
    }
}
