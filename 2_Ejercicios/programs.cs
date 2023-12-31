using System;
public class Ejercicios
{
    public static void Main(string[] args)
    {   
        // Primer Ejercicio - Impresion Hola Mundo
        Console.WriteLine("Hola Mundo");        

        // Segundo Ejercicio - Practica Console.ReadLine(
        Console.WriteLine("Cual es tu animal favorito?");
        string animalName = Console.ReadLine();
        /* Es un metodo de C# que se utiliza para leer el siguiente caracter del flujo de entrada estandar
        Este metodo bloquea su valor devuelto mientras escribe caracteres de entrada y finaliza al presionar
        la tecla Enter. 
        Las llamadas posteriores al metodo ReadLine recuperan en caracter de entrada a la vez. Una vez recuperado
        el caracter de entrada a la vez. Una vez recuperado el caracter final, ReadLine bloquea su retorno de 
        nuevo y el ciclo se repite. */
        Console.WriteLine("El mio tambien");

        // Tercer Ejercicio - Almacenar nombre en variable e imprimir en pantalla
        Console.WriteLine("¿Como te llamas?");
        string name = Console.ReadLine();
        /* Existen diversos metodos para el ingreso de datos desde terminal, es imporante saber que tipo de datos
        se ingresara, por lo cual se utilizara otro metodo dependiendo del dato. El dato de cadena de texto requiere
        ReadLine pero para enteros se usa Read */ 
        Console.WriteLine("Gusto en conocerte " + name);

        // Cuarto Ejercicio - Sumas al cuadrado
        Console.WriteLine("Numero al cuadrado");
        int num = Console.Read();
        int numCuadrado = num * num;
        Console.WriteLine($"El cuadrado de {num} es {numCuadrado}");

    }
}