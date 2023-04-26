using System;
namespace AgenciaInmobiliaria
{

    public class Departamento:Inmueble 

    {
        //Atributos Propios
        //Metodos Propios
        public Departamento (string tipo, double precio)
        {
            TipoInmueble = tipo;
            precio = precio;
        }
    }
}
