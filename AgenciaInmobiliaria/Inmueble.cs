/*INSTITUTO TECNOLÓGICO SUPERIOR DE CINTALAPA
  DOCENTE:JORGE IVÁN BERMÚDEZ RODRIGUEZ
  ALUMNO: JOSÉ MANUEL CRUZ MARTÍNEZ
  PRÁCTICA: HERENCIA*/

using System;
namespace AgenciaInmobiliaria
{

    public class Inmueble
    {
        //Atributos /Por defecto son privados
        //Los atributos deberian ser privados- Manipularlos por propiedades

       protected string TipoInmueble;

        protected string Ubicacion;

       protected int Area;

        protected string Dormitorios;

        protected double Precio;
        //Propiedades set y get / modificadores de acceso

        public string _TipoInmueble
        { get => TipoInmueble; set => TipoInmueble = value; }

        public string _Ubicacion
        { get => Ubicacion; set => Ubicacion = value; }

        public int _Area
        { get => Area; set => Precio = value; }

        public string _Dormitorios
        { get => Dormitorios; set => Dormitorios = value; }

        public double _Precio
        { get => Precio; set => Precio = value; }

        //Metodos

        public void Registrar() { }

        public void Vender()
        {
            Console.WriteLine(TipoInmueble + " ha sido vendida por el precio de " + 350005 + "$");
        }

        public void Alquilar()
        {
            Console.WriteLine(TipoInmueble + " ha sido alquilado por el precio de " + 5260 + "$");
        }
        public void VerDatos()
        {
            Console.WriteLine(TipoInmueble + "\n"
                + Area + "\n"
                + Ubicacion + "\n"
                );
        }

        //Constructor con parametros

        public Inmueble(string tipo, double precio)
        {
            TipoInmueble = tipo;
            Precio = precio;
        }
        //Constructor por defecto- Vacio

        public Inmueble() { }
    }
}