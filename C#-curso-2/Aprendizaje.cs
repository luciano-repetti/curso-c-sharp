// // Crear una lista de objetos de Tipo Producto
// var inventario = new List<Producto>();

// // Añade objetos creados inline a la Lista
// inventario.Add(new Producto("Teclado Mécanico", 5000.50m, 10));
// inventario.Add(new Producto("Mouse Gamer", 2500.00m, 5));
// inventario.Add(new Producto("Monitor Gamer", 12500.50m, 15));

// // Filtrar con LINQ (¡Igual que antes!)
// var productosCaros = inventario.Where(producto => producto.Precio > 3000).ToList();

// foreach (var p in productosCaros)
// {
//     Console.WriteLine($"Producto: {p.Nombre} - Precio: {p.Precio}");
// }

// public class Producto
// {
//     // PROPIEDADES (get/set)
//     public string Nombre { get; set; }
//     public decimal Precio { get; set; }
//     public int Stock { get; set; }


//     //CONSTRUCTOR
//     public Producto(string nombre, decimal precio, int stock)
//     {
//         Nombre = nombre;
//         Precio = precio;
//         Stock = stock;
//     }

//     // UN MÉTODO (COMPORTAMIENTO)
//     public void AplicarDescuento(decimal porcentaje)
//     {
//         Precio -= Precio * (porcentaje / 100);
//     }
// }

