List<VideoJuego> carrito = new();

carrito.Add(new VideoJuego("Harry Potter", 25000.00m, "Mundo abierto"));
carrito.Add(new VideoJuego("Rocket League", 0.00m, "Deporte y Conducción"));
carrito.Add(new VideoJuego("Gta V", 50000.00m, "Accion"));
carrito.Add(new VideoJuego("Fornite", 3000.00m, "Disparos"));
carrito.Add(new VideoJuego("The Witcher", 10000.00m, "RPG"));

var juegoBuscado = carrito.Find(juego => juego.Titulo == "Gta V");

if (juegoBuscado != null)
{
    juegoBuscado.AplicarOferta(10);
    Console.WriteLine($"¡Oferta aplicada a {juegoBuscado.Titulo}!");
    
    juegoBuscado.MostrarDetalles();
}

var juegosMasBaratos = carrito.Where(juego => juego.Precio <= 1500.00m).ToList();


var precioTotal = carrito.Sum(juego => juego.Precio);

Console.WriteLine($"El precio de todos los productos es de: {precioTotal}");
