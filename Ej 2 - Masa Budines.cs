using System;

class Program
{
    static void Main()
    {
        // Constantes
        const int gramosPorBudin = 55;
        const int budinesPorPaquete = 12;
        const int paquetesPorCaja = 20;

        // Solicitar al usuario la cantidad de masa producida
        Console.Write("Ingrese la cantidad de masa producida (en gramos): ");
        int masaTotal = int.Parse(Console.ReadLine());

        // Calcular cantidad total de budines y masa sobrante
        int cantidadBudines = masaTotal / gramosPorBudin;
        int masaSobrante = masaTotal % gramosPorBudin;

        // Calcular la cantidad de paquetes y budines sobrantes
        int totalPaquetes = cantidadBudines / budinesPorPaquete;
        int budinesSobrantes = cantidadBudines % budinesPorPaquete;

        // Calcular la cantidad de cajas completas y paquetes sobrantes
        int cajasCompletas = totalPaquetes / paquetesPorCaja;
        int paquetesSobrantes = totalPaquetes % paquetesPorCaja;

        // Mostrar resultados
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Cantidad total de budines: {cantidadBudines}");
        Console.WriteLine($"Masa sobrante: {masaSobrante} gramos");
        Console.WriteLine($"Cantidad total de paquetes: {totalPaquetes}");
        Console.WriteLine($"Budines sobrantes (fuera de paquete): {budinesSobrantes}");
        Console.WriteLine($"Cantidad de cajas completas: {cajasCompletas}");
        Console.WriteLine($"Paquetes sobrantes (fuera de caja): {paquetesSobrantes}");
    }
}