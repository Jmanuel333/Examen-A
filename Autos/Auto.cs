using System;
class Auto
{
    public string Nombre { get; set; }
public decimal Precio { get; set; }
public string Condicion { get; set; }

public Auto(string nombre, decimal precio, string condicion)
{
    Nombre = nombre;
    Precio = precio;
    Condicion = condicion;
}
}

