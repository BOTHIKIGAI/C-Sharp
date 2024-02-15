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
         var mySet = new HashSet <string> {"Juan", "Esteban", "Cajiao", "Cajiao"};
         /* En C#, un set es una estructura de datos que almacena una colección de datos únicos. Los
            elementos de un set no tienen un orden especifico, y no se puede acceder a ellos mediante
            un indice. 

            Esta estructura no tiene repetidos, por lo cual, si tiene dos datos iguales seran uno solo,
            esto se podra observar en un foreach, a la hora de imprimir cada dato solo se obtendra el 
            Juan - Esteban - Cajiao pero no el segundo Cajiao.

            Si imprimos por consola la variable mySet obtendremos el siguiente valor
            System.Collections.Generic.HashSet`1[System.String] en donde se expecifica que se tiene un
            que se tiene una colección generica de hash set por string.    
         */
         
         // Tupla
         var myTupla = ("Juan", "Esteban", "Cajiao");
         /* 
            Las tuplas son estructuras de datos que permiten almacenar un conjunto de valores de diferentes
            tipos en una sola variable. Las tuplas se declaran entre paréntesis y se separan los valores por
            comas.
         */
         Console.WriteLine(myTupla); // Imprimir todos los valores de la tupla
         /*
            Imprimir por indice en tuplas

            Console.WriteLine(myTupla[0]); No se puede imprimir por indice directamente llamando a myTupla
            Para imprimir por indice se debe almacenar el valor del indice de la tupla en otra variable

         */

         string indiceMyTupla = myTupla.Item1; // En la variable se almcena el valor del Item1
         Console.WriteLine(indiceMyTupla); // Unicamente imprimira el valor del dato en MyTupla

         // 6. Bucles

         // for

         /* 
            El ciclo for es una estructura de control que se utiliza para iterar una secuencia de
            instrucciones de forma repetitiva. El ciclo for permite especificar una expresion de
            inicialización, una condición de continuación y una expreción de iteración.
         */
         for (int index = 0; index < 10; index++ ) 
         {
            Console.WriteLine(index);
         }

         // foreach
         /* 
            El ciclo for each es una estructura que se utiliza para iterar una colección de forma repetitiva.
            El ciclo for each itera sobre los elementos de la colección, asignando cada elemnto a una variable,
            generalmente llamada elemnto o en este caso myItem
         */            
         foreach (var myItem in MyArray)
         {
            Console.WriteLine(myItem);
         }

         foreach (var myItem in myDictionary)
         {
            Console.WriteLine(myItem);
         }

         foreach (var myItem in mySet)
         {
            Console.WriteLine(myItem);
         }

         // 7. Flujos

         /* 
            Las instucciones if, elseif, y else son estrucuturas de control que se utilizan para tomar
            decisiones en el codigo. 
            
            - Las instructores if se utilizan para evaluar una condición y, si la
               condición es verdadera, se ejecuta un bloque de codigo.
            
            - Las instrucciones elseif se utilizan para evaluar una condición adicional si la condición
               de la instrucción if no se cumple.

            - Las instrucciones else se utilizan para ejecutar un bloque de código si ninguna de las otras
               condiciones se cumple.                                
         */

         myInt = 12;
         myBool = false;

         if (myInt == 11 && myBool == true) // Operador Logico -> && -> AND -> Evaluar si ambas condicones son true
         {
            Console.WriteLine("El valor es 11"); 
         }
         else if (myInt == 12 || myBool == false) // Operador Logico -> || -> OR -> Evaluar si almenos una de las condiciones es true
         {
            Console.WriteLine("El valor es 12");
         }
         else 
         {
            Console.WriteLine("El valor no es 11");
         }

         // 8. Funciones
         /* 
            Una función es un bloque de código que se puede utilizar en diferentes partes de un programa.
            Las funciones se pueden utilizar para dividir un programa en tareas pequeñas y manejables. Lo
            que hace que el código sea más facil de leer y comprender.

            Las funciones se definen afuera de la clase main y dentro de la clase main se hace el llamado 
            a las funciones.

            Para llamar a la función se pone el nombre y paretencis, dentro del parentecis se puede tener
            datos o no.
         */

         MyFunction(); 
         MyFunctionReturn(5); 

         // 9. Clases
         var MyClass = new MyClass("Juanes");
         Console.WriteLine(MyClass.myName);
         MyClass.myName = "Juanes Cajiao";
         Console.WriteLine(MyClass.myName);
      }

      // 8. Funciones
      /* 
         Como observamos la función se define afuera del main. Esta puede tener una distinta estructra, desde 
         public a private, definiendo el dato que retorna.

         El nombre de la función no se puede repetir en otra función.
      */
      static void MyFunction()
      {
         Console.WriteLine("Mi función");
      }

      static void MyFunctionReturn(int param)
      {
         Console.WriteLine($"La suma es de 10 mas {param}: {10 + param}");

      }

      // 9. Clases

/* */

      class MyClass
      {
         public string myName {get; set;}

         public MyClass(string myCurrentName)
         {
            myName = myCurrentName;
         }

      }

   }
}
