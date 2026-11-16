using System;
using System.Collections.Generic;
using System.Text;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero { get; set; }
        public string Placa { get; set; }="";
        public string Combustible { get; set; }="";
        public decimal Galones { get; set; }
        public string Pago { get; set; }="";
        public decimal Total { get; set; }

        public override string ToString()
        {
            return "Despacho #" + Numero +
                   " | Placa: " + Placa +
                   " | Combustible: " + Combustible +
                   " | Galones: " + Galones +
                   " | Pago: " + Pago +
                   " | Total: RD$ " + Total.ToString("N2");
        }
    }
}
