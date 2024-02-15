class Program {
    
    static void Main(String[] args) 
    {

        // helloWorld(); // Hello World
        // variables();  // Definición de variables
        // constantes(); // Definición de constantes
        typeCasting(); // Casting a variables

        
    }

    // Primer Hola Mundo
    static void helloWorld() 
    {
        Console.WriteLine("Hola mundo");
        Console.Write("Hola mundo (sin salto de linea)");
    }

    // Declarar variables
    static void variables()
    {
        string name = "Juan";          // string
        int age = 21;                  // Int
        float width = 73.5F;           // float
        double height = 1.73D;         // double
        char firstLetterName = 'J';    // Char
        bool existPerson = true;       // boolean        

        Console.WriteLine($"{name} tiene {age} años de edad, mide {height} m y tiene un ancho de {width}, la primera letra de su nombre es {firstLetterName} y existe {existPerson}");
    }

    // Constantes
    static void constantes()
    {
        const int myNum = 15; // No cambia valor
        Console.WriteLine(myNum);
    }

    // Type casting o transformación de variables a otro tipo de datos

    static void typeCasting()
    {

        // Implicing casting char -> int -> long -> float -> double
        // Explicit casting double -> float -> long -> int -> char

        // Implicing casting
        int myInt = 9;
        Console.WriteLine(myInt.GetType()); // Saber el tipo de dato que es
        double myDouble = myInt; // Automatic casting: int to double
        Console.WriteLine(myDouble.GetType()); // Saber el tipo de dato que es      

        // Expliciting
        double myDoubleA = 9.78;
        int myIntA = (int) myDoubleA;    // Manual casting: double to int

        Console.WriteLine(myDoubleA);   // Outputs 9.78
        Console.WriteLine(myIntA);      // Outputs 9  
    }

}