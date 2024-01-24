using System;

public class Customer {

  public Customer(string name, int salario){
   this.Name = name;
   this.Salario = salario;
  }

    public string Name { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; } 
}