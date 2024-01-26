using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el Nombre de un Cliente y su Sueldo separados por comas");

        string[] employeeData = Console.ReadLine().Split(',');
        Employee employee1 = new Employee(employeeData[0], 
        Double.Parse(employeeData[1]));

        double desc = Nomina.CalcularDescuento(employee1);
        Console.WriteLine("El total de descuento es: " + desc);

    }
}