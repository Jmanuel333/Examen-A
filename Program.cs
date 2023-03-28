/*Instituto Tecnológico Superior de Cintalpa
Programación Orientada a Objetos
Docente: Dr.Jorge Iván Bermúdez Ramirez
Alumno: José Manuel Cruz Martínez
2-"F"
Exámen 2da Unidad*/

using System;
using System.Collections.Generic;

public class Escuela
{
    private List<Dictionary<string, object>> Alumnos = new List<Dictionary<string, object>>();

    public void DarDeAlta(int Matricula, string ApellidoPaterno, string ApellidoMaterno, string Nombre, uint Edad, string Carrera, uint Semestre)
    {
        Dictionary<string, object> alumno = new Dictionary<string, object>();
        alumno.Add("Matrícula", Matricula);
        alumno.Add("Apellido_paterno", ApellidoPaterno);
        alumno.Add("Apellido_materno", ApellidoMaterno);
        alumno.Add("Nombre", Nombre);
        alumno.Add("Edad", Edad);
        alumno.Add("Carrera", Carrera);
        alumno.Add("Semestre", Semestre);
        Alumnos.Add(alumno);
        Console.WriteLine($"Alumno con matrícula {Matricula} agregado a la lista de alumnos.");
    }

    public void ActualizarDatos(int matricula, string campo, object valor)
    {
        Dictionary<string, object> alumno = BuscarAlumno(matricula);
        if (alumno != null)
        {
            alumno[campo] = valor;
            Console.WriteLine("Datos actualizados correctamente.");
        }
        else
        {
            Console.WriteLine($"No se encontró ningún alumno con matrícula {matricula}.");
        }
    }

    public void EliminarAlumno(int matricula)
    {
        Dictionary<string, object> alumno = BuscarAlumno(matricula);
        if (alumno != null)
        {
            Alumnos.Remove(alumno);
            Console.WriteLine($"Alumno con matrícula {matricula} eliminado de la lista de alumnos.");
        }
        else
        {
            Console.WriteLine($"No se encontró ningún alumno con matrícula {matricula}.");
        }
    }

    private Dictionary<string, object> BuscarAlumno(int matricula)
    {
        foreach (Dictionary<string, object> alumno in Alumnos)
        {
            if ((int)alumno["matricula"] == matricula)
            {
                return alumno;
            }
        }
        return null;
    }

    public void LlenadoDeDatos()
    {
        Console.Write("Ingrese la matrícula del alumno: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el apellido paterno del alumno: ");
        string apellidoPaterno = Console.ReadLine();
        Console.Write("Ingrese el apellido materno del alumno: ");
        string apellidoMaterno = Console.ReadLine();
        Console.Write("Ingrese el nombre del alumno: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la edad del alumno: ");
        uint edad = uint.Parse(Console.ReadLine());
        Console.Write("Ingrese la carrera del alumno: ");
        string carrera = Console.ReadLine();
        Console.Write("Ingrese el semestre del alumno: ");
        uint semestre = uint.Parse(Console.ReadLine());
        DarDeAlta(matricula, apellidoPaterno, apellidoMaterno, nombre, edad, carrera, semestre);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Escuela escuela = new Escuela();

        // Ejemplo de uso de los métodos
        escuela.LlenadoDeDatos();
        escuela.ActualizarDatos(123456, "nombre", "Nuevo Nombre");
        escuela.EliminarAlumno(654321);
    }
}

