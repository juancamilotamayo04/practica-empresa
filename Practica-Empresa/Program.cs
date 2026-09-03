using Practica_Empresa;

public class Calculadora
{
    public int Sumar(int a,int b)
    {
        return a+b;
    }
}
public class Program
{
    static void Main()
    {
        var calculo =new Calculadora();

        int suma = calculo.Sumar(10,10);
        Console.WriteLine(suma);     

        var tarea = new Tarea();

        tarea.registrarTarea("Registrar tarea","como usuario quiero poder registrar una tarea.");
        tarea.registrarTarea("Actualizar una tarea", "como usuario quiero poder Actualizar una tarea.");
        tarea.registrarTarea("Eliminar una tarea", "como usuario quiero poder eliminar una tarea despues que haya finalizado.");
    }    
}