using System;
 

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Ingrese el Nombre de un Cliente y su Sueldo separados por comas");
    
    Customer customer1 = new Customer(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));

  Nomina.CalcularDescuento(customer1);
    
  }
}