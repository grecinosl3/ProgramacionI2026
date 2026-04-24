using System;

class Descuentos
{
    static void Main()
    {
        // Arreglo bidimensional: 5 clientes, 5 compras cada uno
        double[,] compras = {
            { 20, 15, 30, 10, 5  },   // Cliente 1
            { 200, 150, 300, 100, 50 }, // Cliente 2
            { 500, 400, 300, 200, 100 }, // Cliente 3
            { 50, 30, 10, 5, 2   },   // Cliente 4
            { 800, 600, 400, 300, 200 }  // Cliente 5
        };

        CalcularDescuentos(compras);
    }

    static void CalcularDescuentos(double[,] compras)
    {
        Console.WriteLine("===== RESUMEN DE COMPRAS Y DESCUENTOS ===\n");

        // Recorrer cada cliente (cada fila)
        for (int cliente = 0; cliente < 5; cliente++)
        {
            double total = 0;

            // Sumar las 5 compras del cliente
            for (int compra = 0; compra < 5; compra++)
            {
                total += compras[cliente, compra];
            }

            // Calcular descuento según las reglas
            double porcentaje = 0;
            string mensaje = "";

            if (total <= 99)
            {
                porcentaje = 0;
                mensaje = "Sin descuento";
            }
            else if (total <= 1000)
            {
                porcentaje = 10;
                mensaje = "10% de descuento";
            }
            else
            {
                porcentaje = 20;
                mensaje = "20% de descuento";
            }

            double descuento = total * (porcentaje / 100);
            double totalFinal = total - descuento;

            // Mostrar resultados del cliente
            Console.WriteLine($"Cliente {cliente + 1}:");
            Console.WriteLine($"  Total de compras : ${total}");
            Console.WriteLine($"  Descuento        : {mensaje} (-${descuento})");
            Console.WriteLine($"  Total a pagar    : ${totalFinal}");
            Console.WriteLine();
        }
    }
}