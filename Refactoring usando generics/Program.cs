using Refactoring_usando_generics.Base;
using Refactoring_usando_generics.Repository;


class Program
{
    static void Main(string[] args)
    {
        var asientoRepo = new AsientoRepository();

        // Agregar algunos asientos
        asientoRepo.Agregar(new Asiento { Id = 1, BusId = 1, NumeroPiso = 1, NumeroAsiento = 1, FechaCreacion = DateTime.Now });
        asientoRepo.Agregar(new Asiento { Id = 2, BusId = 1, NumeroPiso = 1, NumeroAsiento = 2, FechaCreacion = DateTime.Now });
        asientoRepo.Agregar(new Asiento { Id = 3, BusId = 1, NumeroPiso = 2, NumeroAsiento = 1, FechaCreacion = DateTime.Now });
        asientoRepo.Agregar(new Asiento { Id = 4, BusId = 2, NumeroPiso = 1, NumeroAsiento = 1, FechaCreacion = DateTime.Now.AddDays(-1) });

        // Obtener asientos por bus
        Console.WriteLine("Asientos del Bus 1:");
        foreach (var asiento in asientoRepo.ObtenerAsientosPorBus(1))
        {
            Console.WriteLine($"Asiento ID: {asiento.Id}, Piso: {asiento.NumeroPiso}, Número: {asiento.NumeroAsiento}");
        }

        // Obtener asientos por piso
        Console.WriteLine("\nAsientos del Bus 1, Piso 1:");
        foreach (var asiento in asientoRepo.ObtenerAsientosPorPiso(1, 1))
        {
            Console.WriteLine($"Asiento ID: {asiento.Id}, Número: {asiento.NumeroAsiento}");
        }

        // Verificar si un asiento está ocupado
        bool ocupado = asientoRepo.EstaAsientoOcupado(1, 1, 1);
        Console.WriteLine($"\n¿Está ocupado el asiento 1 del piso 1 del bus 1? {ocupado}");

        // Contar asientos disponibles
        int disponibles = asientoRepo.ContarAsientosDisponibles(1);
        Console.WriteLine($"\nAsientos disponibles en el Bus 1: {disponibles}");

        // Obtener asientos creados hoy
        Console.WriteLine("\nAsientos creados hoy:");
        foreach (var asiento in asientoRepo.ObtenerAsientosRecientementeCreados(DateTime.Now))
        {
            Console.WriteLine($"Asiento ID: {asiento.Id}, Bus: {asiento.BusId}, Piso: {asiento.NumeroPiso}, Número: {asiento.NumeroAsiento}");
        }
    }
}