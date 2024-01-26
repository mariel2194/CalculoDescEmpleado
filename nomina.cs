using System;
using System.Collections.Generic;

public static class Nomina
{

    public static double AFP = 2.87;
    public static double ARS = 3.04;

    public static double CalcularDescuento(Employee employee)
    {
        double totalDescuento, descuentoAFP, descuentoARS = 0;
        if (employee.Salario < 7000)
        {
            employee.Salario = 7000;
            descuentoAFP = employee.Salario * AFP/100;
            descuentoARS = employee.Salario * ARS/100;
            totalDescuento = descuentoAFP + descuentoARS;

        }
        else if (employee.Salario > 12000)
        {
            employee.Salario = 12000;
            descuentoAFP = employee.Salario * AFP/100;
            descuentoARS = employee.Salario * ARS/100;
            totalDescuento = descuentoAFP + descuentoARS;

        }
        else
        {
            descuentoAFP = employee.Salario * AFP;
            descuentoARS = employee.Salario * ARS;
            totalDescuento = descuentoAFP + descuentoARS;
        }
        return totalDescuento;
    }
}