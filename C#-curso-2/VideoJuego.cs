public class VideoJuego
{
    public string Titulo;
    public decimal Precio;
    public string Genero;

    public VideoJuego(string titulo, decimal precio, string genero)
    {
        Titulo = titulo;
        Precio = precio;
        Genero = genero;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Juego: {Titulo} | Género: {Genero} | Precio: {Precio}");
    }

    public void AplicarOferta(decimal porcentaje)
    {
        Precio -= Precio * (porcentaje / 100);
    }
}