// decimal.Parse() -> Este metodo es peligroso si el usuario
// escribe "hola" en el método de entrada el código explota, por eso
// usamos decimal.TryParse que devuelve un true si se puedo convertir y si no false.
using System.Diagnostics.Tracing;

Console.Write("Ingresa el precio: ");

string entrada = Console.ReadLine() ?? "";

// El valor convertido se guarda en 'precioSalida' si tiene éxito
if (decimal.TryParse(entrada, out decimal precioSalida))
{
    Console.WriteLine($"Éxito: {precioSalida}");
}
else
{
    Console.WriteLine("Error: Eso no es un número válido.");
}

// No siempre se deja que se puedan tocar o acceder a las variables internas de una clase.
// Public: El dato es visible desde cualquier parte del programa.
// Private: El dato solo vive dentro de las llaves { } de la clase. Nadie de afuera lo puede ver ni tocar.

// Despues estan get y set que controlan la lectura y la escritura de una propiedad.
// get: "Dame el valor". Se ejecuta cuando haces var x = objeto.Propiedad
// set: "cambiá el valor". Se ejecuta cuando haces objeto.propiedad = valor;

// Combo que mas se utiliza en backend.
// public string Nombre { get; private set; }
// Quiero que todos puedan acceder al valor de Nombre, pero que no se pueda
// modificar desde afuera.


// Los enum sirven para tener opciones fijas que vengan del programa
// y no dependan del usuario con posibles faltas de ortografia o tipeo
public enum Genero
{
    Accion,
    Rpg,
    Aventura,
    Deperte,
    MundoAbierto
}
