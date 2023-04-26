using System;

namespace AgenciaInmobiliaria {

    class Program
{

    static void Main(string[] args)
    {
        //Creamos objeto/instancia
        // Inmueble Casa= new Inmueble();
        // Casa._TipoInmueble="Casa de Campo";
        // Casa._Area=120;
        // Casa._Ubicacion="Avenida los rios";
        // Casa.VerDatos();

        //Inmueble Departamento= new Inmueble("Departamento Duplex",3200);
        // Departamento.Alquilar();

        //Creamos objeto/instancia
        Casa ObjetoCasa = new Casa("Casa de Campo",350005);
        ObjetoCasa.Vender();

        Departamento ObjDepa = new Departamento("Departamento Triplex",5260);
            ObjDepa.Alquilar();
    }
}
}
