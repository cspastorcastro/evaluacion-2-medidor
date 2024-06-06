using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class MedidorDAL : IMedidorDAL
    {
        public static List<Medidor> listaMedidores;
        public List<Medidor> ObtenerMedidores()
        {
            return listaMedidores;
        }
    }
}
