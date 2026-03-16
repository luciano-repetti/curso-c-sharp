// Cambiando double por decimal para evitar el 229.99999
List<decimal> precios = new List<decimal> { 150.25m, 200.0m, 55.8m, 80.0m };

Console.WriteLine("Por favor agregá un nuevo precio: ");
string precioDeUsuario = Console.ReadLine() ?? "0";

//Usamos "double.Parse" y no "Convert.ToDouble" porque sabemos que el valor nunca sera null.
decimal nuevoPrecio = decimal.Parse(precioDeUsuario, System.Globalization.CultureInfo.InvariantCulture);

precios.RemoveAt(2);

for (int i = 0; i < precios.Count; i++)
{
    precios[i] = precios[i] * 1.15m;
}

List<decimal> preciosAltos = precios.Where(precio => precio >= 100.0m).ToList();

decimal? existeDocientosTreinta = precios.Find(precio => precio == 230.0m);

if (existeDocientosTreinta == 230.0m)
{
    Console.WriteLine("Existe el numero 230.0 en la lista de precios");
}
else
{
    Console.WriteLine("El numero 230.0 no existe en la lista de precios");
}

Console.WriteLine($"Elementos totales de la lista 'precios': {precios.Count}");
Console.WriteLine($"El promedio de precios de la lista de 'precios': {precios.Average()}");

foreach (double precio in preciosAltos)
{
    Console.WriteLine(precio);
}

/*
  RESUMEN DE APRENDIZAJE: C# List<T> y Fundamentos
  -----------------------------------------------
  
  1. LIST VS ARRAY:
     - Array (int[]): Tamaño fijo, más rápido, vive en bloque contiguo.
     - List (List<int>): Objeto "Wrapper" dinámico. Crece duplicando su 
       array interno cuando llega al límite de su 'Capacity'.

  2. MEMORIA (Stack vs Heap):
     - La variable de la lista vive en el STACK (es un puntero/referencia).
     - El objeto Lista y su array de datos viven en el HEAP.
     - Al crecer la lista, la dirección del objeto en el Heap no cambia, 
       pero su puntero interno a los datos sí (se mueve a un array nuevo).

  3. OPERACIONES ESENCIALES:
     - .Add(val)      -> Agrega al final.
     - .RemoveAt(i)   -> Borra por índice (desplaza el resto, ojo con performance).
     - .Count         -> Cantidad de elementos actuales (el .length de JS).
     - .Capacity      -> Tamaño del array interno antes de volver a crecer.

  4. LINQ (Los "Array Methods" de C#):
     - .Where(x => ...)  -> Filtra (equivalente a .filter en JS).
     - .Find(x => ...)   -> Busca el primero (.find en JS). Devuelve null si no está.
     - .ToList()         -> Ejecuta la "receta" de LINQ y la guarda en una lista real.
     - .Average(), .Max(), .Min(), .Sum() -> Agregadores rápidos.

  5. LECCIONES DE LA TAREA (Tips de Pro):
     - TIPADO: Console.ReadLine() siempre devuelve string. Hay que usar Parse().
     - WARNING CS8600: Usar 'type?' (ej: string?) para avisar que algo puede ser nulo.
     - PRECISIÓN: 'double' no es exacto para dinero (230.0 != 229.999...). 
       Para finanzas, usar el tipo 'decimal'.
     - CULTURA: C# usa la configuración regional de la PC (coma vs punto decimal).
*/