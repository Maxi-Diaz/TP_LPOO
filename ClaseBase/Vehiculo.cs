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
        private string lin_Id;

        public string Lin_Id
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
        private string veh_TipoVehiculo;

        public string Veh_TipoVehiculo
        {
            get { return veh_TipoVehiculo; }
            set { veh_TipoVehiculo = value; }
        }
        private string veh_ClaseVehiculo;

        public string Veh_ClaseVehiculo
        {
            get { return veh_ClaseVehiculo; }
            set { veh_ClaseVehiculo = value; }
        }
        private decimal veh_Precio;

        public decimal Veh_Precio
        {
            get { return veh_Precio; }
            set { veh_Precio = value; }
        }

        public Vehiculo(string matricula, string marca, string linea, int modelo,
            string color, int puerta, bool gps, string tipo, string clase, decimal precio)
        {
            Veh_Matricula = matricula;
            Veh_Marca = marca;
            Lin_Id = linea;
            Veh_Modelo = modelo;
            Veh_Color = color;
            Veh_Puerta = puerta;
            Veh_GPS = gps;
            Veh_TipoVehiculo = tipo;
            Veh_ClaseVehiculo = clase;
            Veh_Precio = precio;
        }
    }
}
