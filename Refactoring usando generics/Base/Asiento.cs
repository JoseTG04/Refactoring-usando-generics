using Refactoring_usando_generics.Interfaces;

namespace Refactoring_usando_generics.Base
{
    public class Asiento : IEntity
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
