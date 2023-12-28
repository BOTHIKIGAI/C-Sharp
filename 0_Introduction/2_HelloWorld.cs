using System;

namespace CSharpHelloWorld
{
    class HelloWorld 
    {
       static void Main(string[] args)
        {
            // 0. Comentarios
            // Comentario de una sola linea
            /* Comentario de multiples lineas */
            
            // 1. Imprimer en consola
            Console.WriteLine("Hello, World!");

            // 2. Variables y Constate
            /* Un lenguaje fuertemente tipado, por lo al iniciar una nueva variable se debe establecer
               el tipo de dato que es esta */
            
            // Tipo de variable + nombre de variable + valor de variable
            string myString = "Esto es una cadena de texto"; // Variable inicializada como String
            Console.WriteLine(myString); // Imprime el valor de la variable myString

            // Cambiar valor de una variable
            myString = "Nuevo valor de la variable myStrig";
            Console.WriteLine(myString); // Imprime el nuevo valor de la variable myString

            int myInt = 1; // Variable inicializada como int
            Console.WriteLine(myInt);

            float myFloat = 5.5f; 
            /* Variable inicializada como float y como en Java se termina con f 
               ya que tiene una longitud menor a lo que seria un dato double.
               La f indica que el valor esta representado como un flotante de 
               precisión simple (32 bits) */
            Console.WriteLine(myFloat);

            double myDouble = 6.5;
            /* Variable inicializada como Double ya que almacena una mayor longitud
               y no tiene la necesidad de usar una f, siendo asi mayor que float ya
               que es el doble siendo de 64 bits */
            Console.WriteLine(myFloat);

            dynamic myDynamic = 6;
            /* Variable inicializada como Dinamica o Dynami, es de tipo estatica, pero un
               objeto de tipo Dynamic omite la comprobación de tipos estaticos. Por lo cual
               su tipo de dato puede cambiar de manera constante. */
            Console.WriteLine(myDynamic);
            myDynamic = "Ahora soy String";
            Console.WriteLine(myDynamic);

            var myVar = 1;
            /* Variable inicializada sin definir el tipo de datos que es. Esta misma inferira
               el tipo de dato que es, en este caso se definira que es int y no podra convertirse
               a otro tipo de dato como Dynamic. */
            Console.WriteLine(myVar);

            bool myBool = true;
            /* Variable inicializada como booleano, por lo cual solo podra tomar valores true or 
               false. */
            Console.WriteLine(myBool);

            const string MyConstString = "Mi constante String";
            /* Un dato constante es uno que siempre tendra el mismo valor y no podra ser modificado como
               lo podria ser una variable. 
               Al momento de definir una constante se debera especificar el tipo de dato que sera. */
            Console.WriteLine(MyConstString);

            // 3. Impresión de información

            // Concatenar
            Console.WriteLine("Valor de la variable entera myInt = " + myInt);

            // Interpolar (se usa el simbolo $ al inicio y los {} para los datos)
            Console.WriteLine($"Valor de la variable double myDouble = {myDouble}");

            // 4. Operaciones

            // Suma
            myInt = myInt + 5; // Sumar el valor actual de la variable mas 1 mediante el operador de adición +
            Console.WriteLine(myInt - 1); // Valor de myInt - 1, no cambia el valor de la variable
            Console.WriteLine(myDouble + myFloat); // Aunque sean datos diferente se pueden realizar operaciones entre ellos

            // 5. Estructuras de datos

            // Array
            var MyArray = new string[]  {"Juan", "Juanes", "Milan"};
            /* Se inicializa un Array y se especifica que es de tipo String y unicamente podra almacenar datos
               de ese tipo que definimos. */
            Console.WriteLine(MyArray); // Nos confirmara la existencia del Array, mediante el System.String[], pero no sus datos
            Console.WriteLine(MyArray[0]); // Para imprimir un valor de un Array se debe definir el indice del mismo
            Console.WriteLine(MyArray[1]); 
            Console.WriteLine(MyArray[2]);
                
            // Cambiar valor de un indice de un array
            MyArray[0] = "Lasagna";
            /* En este caso se cambia el valor del indice 0 el cual es Juan por el otro valor Lasagna. 
               Es importante tener en cuenta que no se puede agregar nuevos datos al Array, por lo que
               su longitud siempre sera de 0,1 y 2 (tres datos) */
            
            // Dictionay
            var myDictionary = new Dictionary<string, int>
            {
               {"Juanes", 20},
               {"Milan", 2},
               {"Tara", 8}
            };
            /* 
               Es una estructura de datos que almacena datos de forma clave-valor. Cada elemento de un
               diccionario esta formado por una clave y un valor. La clave es un identificador unico
               que se utiliza para acceder al valor. El valor puede ser cualquier tipo.
               
               Cuando se crea la estructura de datos bajo el nombre de myDictionary se define el tipo
               de clave que en este es string y luego entero.

               Los datos se almacenan dentro de un array, el cual debe seguir la estructura solicitada.
               <string, int>
            */

            Console.WriteLine(myDictionary["Juanes"]);
            /* Imprimir datos del diccionario myDictionary, cuando llamamos a la clave string "Juanes"
               imprimira el valor int 20. */

            // Set
            var mySet = new HashSet <string> {"Juan", "Esteban", "Cajiao"};

        }
    }
}
