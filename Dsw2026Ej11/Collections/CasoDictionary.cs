namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        if (!diccionarioAlumnos.ContainsKey(alumno.Id))
        {
            diccionarioAlumnos.Add(alumno.Id, alumno);
        }
    }

    public Alumno ? BuscarAlumno(int legajo)
    {
        if(diccionarioAlumnos.TryGetValue(legajo, out Alumno ? alumno))
        {
            return alumno;
        }
        return null;
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return diccionarioAlumnos;
    }
    
    public void EliminarAlumno(int legajo)
    {
        diccionarioAlumnos.Remove(legajo);
    }
} 
