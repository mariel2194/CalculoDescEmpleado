using System;

public class Employee
{

    public Employee(string name, double salario) 
    {
        this.Name = name;
        this.Salario = salario;
    }

    public string Name { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
}