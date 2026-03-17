public class Componente
{
    public string Nombre { get; private set; }
    public decimal Precio { get; private set; }
    public int Stock { get; private set; }
    public TipoComponente Categoria { get; private set; }

    public Componente(string nombre, decimal precio, int stock, TipoComponente categoria)
    {
        Nombre = nombre;
        Precio  = precio;
        Stock = stock;
        Categoria = categoria;
    }
}

public enum TipoComponente
{
    Procesador,
    Grafica,
    Ram,
    Almacenamiento
}