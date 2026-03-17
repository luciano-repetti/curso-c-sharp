// Guía rápida de LINQ

// Necesitas un subconjunto de elementos ejemplo en una lista de numeros,
// desde el numero 10 hacia arriba. Lo que hara es devolverte una nueva lista
// con los elementos que cumplen esa condicion, y la lista sera de tipo IEnumerable<T>.
// Tip: IEnumerable<T> se puede convertir a una lista con el método .TolIst().
// El método a usar: .Where(x => ...)

// Necesitas modificar una propiedad de forma iterada a una lista,
// Por ejemplo modificando el nombre de todos los objetos de la lista
// lo que hará es devolver una nueva lista del tipo IEnumerable<T>. Es parecido al MAP de js.
// El método a usar es .Select(x => ...)

// Si necesito ordenar una lista (A - Z o de precios). Devuelve una lista de tipo IOrderedEnumerable<T>.
// El método a usar es .OrderBy(x => ...)

// Si se necesita saber si existe al menos un objeto que cumpla x condición. Devuelve bool (booleano).
// El método a usar es .Any(x => ...)

// Necesitas el total de una propiedad numerica, por ejemplo para sumar el total de una compra.
// Suma int, double y decimal y retorna exactamente lo mismo.
// El método a usar es .Sum(x => ...)

// Necesitas el primero elemento que coincida con la condición que estes dando. Retorna T? (objeto o nulo).
// El método a utilizar es .FirstOrDefault(x => ...)
