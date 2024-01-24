using System;
using System.Collections.Generic;

public static class Nomina{
  
   public static double AFP = 2.87;
   public static double ARS = 3.04;

  public static double CalcularDescuento(Customer customer){
    
    double totalDescuento, descuentoAFP, descuentoAFP = 0;
    if(customer.Salario <7000){
      customer.Salario = 7000;
      descuentoAFP = customer.Salario * AFP;
      descuentoARS = customer.Salario * ARS;
      totalDescuento= descuentoAFP + descuentoARS; 
      return totalDescuento;
    }
    else (customer.Salario > 12000)
    customer.Salario = 12000
    descuentoAFP = customer.Salario * AFP;
    descuentoARS = customer.Salario * ARS;
    totalDescuento= descuentoAFP + descuentoARS; 
    return totalDescuento;
  }
  
}