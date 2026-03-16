// using System.Linq;

// List<string> juegos = new List<string> ();

// List<string> sagas = new List<string> {"The witcher", "Dark Souls"};

// int cantidad = sagas.Count;
// int espacio = sagas.Capacity;

// Console.WriteLine($"La cantidad de objetos de la lista sagas es: {cantidad}");
// Console.WriteLine($"El espacio de la lista sagas es: {espacio}");

// // Agrega un elemento al final.
// sagas.Add("Elden ring");

// // Inserta un elemento en la posicion dicha en el primero paramentro y en el segundo parametro el valor.
// sagas.Insert(0, "Zelda");

// // Remueve el primer elemento encontrado que se le pasa por parametro.
// sagas.Remove("Dark Souls");

// // Remueve el elemento por indice.
// sagas.RemoveAt(0);

// // Comprueba si existe el elemento que se le pasa por paramentro.
// bool existeZelda = sagas.Contains("Zelda");

// cantidad = sagas.Count;
// espacio = sagas.Capacity;

// Console.WriteLine($"La cantidad de objetos de la lista sagas es: {cantidad}");
// Console.WriteLine($"El espacio de la lista sagas es: {espacio}");

// Console.WriteLine($"Existe Zelda? {existeZelda}");

// // 1. FILTRAR (Devuelve una nueva lista con los que cumplen la condición)
// // Equivale al .filter() de JS
// // Importante: Where() devuelve un IEnumerable (un iterador), por eso usamos .ToList() para "materializar" la lista
// List<string> largas = sagas.Where(s => s.Length > 10).ToList();

// Console.WriteLine("Sagas con nombres largos:");
// largas.ForEach(s => Console.WriteLine($"- {s}"));

// // 2. ENCONTRAR UNO (Devuelve el primer elemento que coincida)
// // Equivale al .find() de JS
// // Si no encuentra nada, devuelve null (en tipos de referencia)
// // El simbolo "?" al tipo de dato le decis a C# que crees que es string, pero que puede ser null
// string? juego = sagas.Find(s => s.StartsWith("The"));
// Console.WriteLine($"Primer juego que empieza con 'The': {juego}");

// // 3. CONTAR (Con condición)
// int cuantosThe = sagas.Count(s => s.Contains("The"));
// Console.WriteLine($"Cantidad de sagas con la palabra 'The': {cuantosThe}");

// // Input entrada de datos
// Console.WriteLine("Ingresa una nueva saga de videojuegos: ");
// string sagaDeUsuario = Console.ReadLine() ?? "0";
// if (sagaDeUsuario != null)
// {
//     sagas.Add(sagaDeUsuario);
// }

// //Foreach para leer o mostrar
// foreach (string s in sagas)
// {
//     Console.WriteLine(s);
// }

// //for para modificar
// for (int i = 0; i < sagas.Count; i++)
// {
//     Console.WriteLine(sagas[i]);
// }