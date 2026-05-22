using Dsw2026Ej11.Domain;
using System;
using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(101, "Carlos", 8.5);
        Alumno a2 = new Alumno(102, "Maria", 9.0);
        Alumno a3 = new Alumno(103, "Juan", 7.0);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        Console.WriteLine("--- Todos los alumnos ---");
        foreach (var a in casoList.RetornarLista()) Console.WriteLine(a);

        Console.WriteLine("\n--- Buscar alumno existente ('Maria') ---");
        var enc = casoList.BuscarPorNombre("Maria");
        if (enc != null) Console.WriteLine(enc);

        Console.WriteLine("\n--- Buscar alumno inexistente ('Pedro') ---");
        var noEnc = casoList.BuscarPorNombre("Pedro");
        if (noEnc == null) Console.WriteLine("No existe");

        Console.WriteLine("\n--- Eliminar a Carlos y mostrar ---");
        casoList.EliminarAlumno(a1);
        foreach (var a in casoList.RetornarLista()) Console.WriteLine(a);

        Console.WriteLine("\n--- Eliminar el primer elemento y mostrar ---");
        casoList.EliminarEnPosicion(0);
        foreach (var a in casoList.RetornarLista()) Console.WriteLine(a);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(201, "Sofia", 8.8);
        Alumno a2 = new Alumno(202, "Lucas", 6.5);
        Alumno a3 = new Alumno(203, "Ana", 9.2);

        casoDict.AgregarAlumno(a1);
        casoDict.AgregarAlumno(a2);
        casoDict.AgregarAlumno(a3);

        Console.WriteLine("--- Todos los alumnos en Diccionario ---");
        foreach (var kvp in casoDict.RetornarDiccionario()) Console.WriteLine($"Clave: {kvp.Key} -> {kvp.Value}");

        Console.WriteLine("\n--- Buscar por clave existente (202) ---");
        var enc = casoDict.BuscarAlumno(202);
        if (enc != null) Console.WriteLine(enc);

        Console.WriteLine("\n--- Buscar por clave inexistente (999) ---");
        var noEnc = casoDict.BuscarAlumno(999);
        if (noEnc == null) Console.WriteLine("No existe");

        Console.WriteLine("\n--- Eliminar por clave (201) y mostrar ---");
        casoDict.EliminarAlumno(201);
        foreach (var kvp in casoDict.RetornarDiccionario()) Console.WriteLine($"Clave: {kvp.Key} -> {kvp.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("1. Primero: " + casoLinq.GetPrimero().Titulo);
        Console.WriteLine("2. Último: " + casoLinq.GetUltimo().Titulo);
        Console.WriteLine($"3. Total de Precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n5. Ids mayores a 15:");
        foreach (var l in casoLinq.GetListById()) Console.WriteLine($"- {l.Titulo}");

        Console.WriteLine("\n6. Libros en formato string (Moneda):");
        foreach (var s in casoLinq.GetLibros()) Console.WriteLine($"- {s}");

        Console.WriteLine($"\n7. Mayor Precio: {casoLinq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"8. Menor Precio: {casoLinq.GetMenorPrecio().Titulo}");

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var l in casoLinq.GetMayorPromedio()) Console.WriteLine($"- {l.Titulo}");

        Console.WriteLine("\n10. Libros ordenados (Descendente):");
        foreach (var l in casoLinq.GetLibrosOrdenados()) Console.WriteLine($"- {l.Titulo}");
    }
}