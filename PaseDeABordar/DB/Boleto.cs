using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseDeABordar.DB
{
    public class Boleto
    {
        public Pasajero Pasajero { get; set; }
        public Vuelo Vuelo { get; set; }
        public string NumeroAsiento { get; set; }
        public bool TieneMaleta { get; set; }
        public string NumeroBoleto { get; set; }
        public bool CheckInRealizado { get; set; }
        public bool HaAbordado { get; set; }
    }
}
