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
    }    
}