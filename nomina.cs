public static class Nomina{
  
   public static double AFP = 2.87;
   pubic static double ARS = 3.04;

  public double CalcularDescuento(Customer customer){
  
    double descuento = 0;
    if(customer.Salario <7000){
      customer.Salario = 7000
      double descuentoAFP = customer.Salario * AFP;
      double descuentoARS = customer.Salario * ARS;
      return descuentoAFP + descuentoARS;      
    }
    if(customer.Descuentos.Contains(Descuentos.ARS)){
      descuento += customer.Descuentos[Descuentos.ARS];
    }
    return descuento;
  }
  
}