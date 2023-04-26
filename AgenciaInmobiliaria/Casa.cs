using System;
namespace AgenciaInmobiliaria
{
    public class Casa:Inmueble
    {
        //Atributos Propios
        //Metodos Propios

        public Casa(string tipo, double precio) {
            TipoInmueble = tipo;
            Precio = precio;
        }
    }
}