namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;
using System.Linq;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> listAlumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        listAlumnos.Add(alumno);
    }

    public List<Alumno> RetornarLista()
    {
        return listAlumnos;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        return listAlumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, System.StringComparison.OrdinalIgnoreCase));
    }

    public void EliminarAlumno(Alumno alumno)
    {
        listAlumnos.Remove(alumno);
    }

    public void EliminarEnPosicion(int index)
    {
        if(index >= 0 && index < listAlumnos.Count)
        {
            listAlumnos.RemoveAt(index);
        }
    }
}
