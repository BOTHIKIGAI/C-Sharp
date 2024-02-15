class Program {
    
    static void Main(String[] args) 
    {

        // helloWorld(); // Hello World
        // variables();  // Definición de variables
        // constantes(); // Definición de constantes
        // typeCasting(); // Casting a variables
        // inputData(); // Ingresar data por terminal
        // operadores(); // Operadores aritmeticos
        // operadoresAsignamiento(); // Operadores de asignamiento
        // operadoradorComp(); // Operadores Comparacion
        // operadoresLogicos(); // Operadores Logicos
        // metodMatem(); // Math library
        metodString();

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

        // Examples 
        myInt = 10;
        myDouble = 5.25D;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt)); // Convert int to string
        Console.WriteLine(Convert.ToDouble(myInt)); // Convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble)); // Convert double to int
        Console.WriteLine(Convert.ToString(myBool)); // Convert bool to string

    }

    // UserInput
    static void inputData() 
    {

        // String
        Console.WriteLine("Ingresar usuario: ");
        string userName = Console.ReadLine();

        // Int
        Console.WriteLine("Ingresa tu edad: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La edad de {userName} es de {age} años");
    }

    // Operadores
    static void operadores()
    {
        // Suma
        int x = 100 + 50; 
        int y = 50;
        int z = x + y;
        Console.WriteLine($"El valor de X es {x}, el valor de Y es {y}, la suma de X mas Y es de {z}");

        // Resta
        int a = 10;
        int b = 5;
        int c = a - b;
        Console.WriteLine($"El valor de A es {a}, el valor de B es {b}, la resta de A menos B es de {c}");

        // Multiplicación
        int t = y * b;
        Console.WriteLine($"El valor de Y es {y}, el valor de B es {b}, la multiplicación entre Y y B es {t}");

        // División
        double r = t/b;
        Console.WriteLine($"El valor de T es {t}, el valor de B es {b}, la división entre T y B es {r}");

        // Modulo
        double m = 3;
        double q = 2;
        double w = m%q;
        Console.WriteLine($"El valor de M es {m}, el valor de Q es {q}, el modulo entre M y Q es {w}");
        
        // Incermentear y decrementar
        int f = 1;
        f++; // Incrementar
        Console.WriteLine($"Incrementar el valor de F a mas 1: {f}");
        f--;
        Console.WriteLine($"Decrementar el valor de F a menos 1: {f}");

        
    }

    // Operadores de asignamiento
    static void operadoresAsignamiento()
    {
        int x = 10;
        x += 5; // Suma el valor de x mas 5
        x -= 2; // Resta el valor de x menos 2
        x *= 2; // Multiplica el valor de x por 2
        x /= 2; // Divide el valor de x entre 2
        x %= 4; // Modulo de la división de x entre 4
    }

    // Operadores de comparación
    static void operadoradorComp()
    {
       int x = 5;
       int y = 3;
       Console.WriteLine($" ¿x es mayor que y? {x > y}");
       Console.WriteLine($" ¿x es menor que y? {x < y}");
       Console.WriteLine($" ¿x es igual que y? {x == y}");
       Console.WriteLine($" ¿x es diferente que y? {x != y}");
       Console.WriteLine($" ¿x es igual o mayor que y? {x >= y}");
       Console.WriteLine($" ¿x es igual o menor que y? {x <= y}");

    }

    // Operadores de logicos
    static void operadoresLogicos()
    {

        // Operador && -> Todas las operaciones logicas deben ser logicas
        int x = 10;
        bool comparLog = (x < 5 && x < 9);
        Console.WriteLine($"¿X es menor que 5 y 9? {comparLog}");
        comparLog = (x > 5 && x > 9);
        Console.WriteLine($"¿X es mayor que 5 y 9? {comparLog}"); 
    }
    
    // Metodos de Math
    static void metodMatem()
    {
        
        Console.WriteLine(Math.Max(5, 10)); // Num maximo entre nums
        Console.WriteLine(Math.Min(5,10)); // Num maximo entre nums
        Console.WriteLine(Math.Sqrt(64)); // Raiz de num
        Console.WriteLine(Math.Abs(-4.7)); // Devolver valor en positivo
        Console.WriteLine(Math.Round(9.99)); // Redondear numero
    }

    // Metodos de String
    static void metodString()
    {   
        // Longitud string
        string txt = "ABCDEF";
        Console.WriteLine("La longitud de la variable txt es de " + txt.Length);

        // Mayusculas y Minusculas
        string word = "Hola Mundo";
        Console.WriteLine(word.ToUpper());
        Console.WriteLine(word.ToLower());
    }

    // Acceso a los string
    static void accesString()
    {
        
    }

}