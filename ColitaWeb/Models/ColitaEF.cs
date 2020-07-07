using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColitaWeb.Models
{
    public class ColitaEF
    {
        public Guid Id { get; set; }
        public string ColitaName { get; set; }
        public string ColitaDescription { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsActive { get; set; }
        public EstadoDeColita EstadoDeColita { get; set; }
    }
    public enum EstadoDeColita : int
    {
        Uff = 0,
        Reluciente = 1,
        Bonita = 2,
        Bien = 3,
        MasoMenos = 4,
        Chafa = 5,
        Sucia = 6,
        CheMugrero = 7
    }
}
