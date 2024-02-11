// See https://aka.ms/new-console-template for more information
Console.WriteLine();

//Leer 10 series de películas y la categoría de estas, mostrar en pantalla los datos.
// Declarar un arreglo para almacenar las series de películas


string[] series = new string[10];

// Declarar un arreglo para almacenar las categorías de las series
string[] categorias = new string[1];

// Leer los datos de las series y categorías
for (int i = 0; i < series.Length; i++)
{
    Console.WriteLine("Ingrese el nombre de la pelicula #{0}:",( i + 1));
    series[i] = Console.ReadLine();

    Console.WriteLine("Ingrese la categoría de la pelicula #{0}:", (i + 1));
    categorias[i] = Console.ReadLine();
}

// Mostrar los datos en pantalla
Console.WriteLine("Datos de las series de películas:");
for (int i = 0; i < categorias.Length; i++)
{
    Console.WriteLine("pelicula {0}:  y  Categoría: {1}", series[i], categorias[i]);
}

Console.ReadLine();
