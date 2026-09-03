using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Empresa
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Descripcion { get; set; }


        public void registrarTarea(int id, string titulo, string descripcion)
        {
                List<Tarea> lista = new List<Tarea>();
                var tareas = new Tarea
                {
                    Id = id,
                    Titulo = titulo,
                    Descripcion = descripcion
                };
                bool encontrar = false;
                foreach (var tarea in lista)
                {
                    if (tarea.Titulo.Equals(titulo) || tarea.Descripcion.Equals(descripcion))
                    {
                    encontrar = true;
                    }
                }
                if (encontrar)
                {
                    Console.WriteLine("ya existe una tarea con ese titulo/o descripcion. ");

                }
                else
                {
                    lista.Add(tareas);
                    int contador = 1;
                    tareas.Id = contador++;
                    Console.WriteLine($"Se agrego una tarea con el titulo {tareas.Titulo} y el Id: {tareas.Id}.");
                }

        }
    }
}
