using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Lectura
    {
        private int codigoMedidor;
        private DateTime fechaLectura;
        private double consumo;

        public int CodigoMedidor { get => codigoMedidor; set => codigoMedidor = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public double Consumo { get => consumo; set => consumo = value; }

        public override string ToString()
        {
            return codigoMedidor.ToString() + "|" + fechaLectura.ToString() + "|" + consumo.ToString();
        }
    }
}
