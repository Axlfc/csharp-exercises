// LINQ

// Origen de datos
int [] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// Obtener datos
var pares =
    from numero in numbers
    where (numero % 2) == 0
    select numero;

var impares =
    from numero in numbers
    where (numero % 2) != 0
    select numero;

var nums =
    from numero in numbers  
    where (numero > 5 && numero <= 8)
    select numero;

// Ejecutar consulta

foreach (var num in pares) {
    Console.Write(num + " ");
}
Console.WriteLine(" ");
foreach (var num in impares) {
    Console.Write(num + " ");
}
Console.WriteLine(" ");
foreach (var num in nums) {
    Console.Write(num + " ");
}


// Utilizar en nuestro programa

// C#