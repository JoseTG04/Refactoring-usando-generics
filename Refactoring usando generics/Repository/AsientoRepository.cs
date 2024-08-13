using Refactoring_usando_generics.Interfaces;
using Refactoring_usando_generics.Base;

namespace Refactoring_usando_generics.Repository
{
    public class AsientoRepository : Repository<Asiento?>
    {
        public List<Asiento> ObtenerAsientosPorBus(int busId)
        {
            return _entities.Where(a => a.BusId == busId).ToList();
        }

        public List<Asiento> ObtenerAsientosPorPiso(int busId, int numeroPiso)
        {
            return _entities.Where(a => a.BusId == busId && a.NumeroPiso == numeroPiso).ToList();
        }

        public bool EstaAsientoOcupado(int busId, int numeroPiso, int numeroAsiento)
        {
            return _entities.Any(a => a.BusId == busId && a.NumeroPiso == numeroPiso && a.NumeroAsiento == numeroAsiento);
        }

        public int ContarAsientosDisponibles(int busId)
        {
            // Asumiendo que cada bus tiene un número fijo de asientos, por ejemplo, 40
            const int totalAsientosPorBus = 40;
            int asientosOcupados = _entities.Count(a => a.BusId == busId);
            return totalAsientosPorBus - asientosOcupados;
        }

        public List<Asiento> ObtenerAsientosRecientementeCreados(DateTime fecha)
        {
            return _entities.Where(a => a.FechaCreacion.Date == fecha.Date).ToList();
        }
    }
}
