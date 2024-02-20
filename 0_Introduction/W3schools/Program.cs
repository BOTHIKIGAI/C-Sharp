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
        // metodString(); // Metodos con los strings
        // accesString(); // Metodos para la impresión
        // booleans(); // Sobre los Booleans
        // condicionales(); // Condicionales
        // mientrasTanto(); // While (mientras tanto)
        // paraCada(); // Ciclo for
        // paraCadaUno(); // Para cada uno o for each
        // romperCiclo(); // Break
        continuaCiclo(); // Continua

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
        // Acceder a un caracter dentro de un string
        string hello = "Hello";
        Console.WriteLine(hello[0]); // Acceder al primer caracter

        // Saber en que parte esta ubicado un caracter dentro de un string
        Console.WriteLine(hello.IndexOf("e"));

        // Saltar de linea
        Console.WriteLine("Hola!!! \n¿como estas");
        Console.Write("\t Estoy bien");
    }

    // Booleans
    static void booleans() 
    {   
        // Variable bool
        bool isCSharpFun = true;
        bool isFishTasty = false;
        Console.WriteLine(isCSharpFun);
        Console.WriteLine(isFishTasty);

        // Operadores de comparación
        int x = 5;
        int y = 10;
        Console.WriteLine(x > y); // X es mayor que Y
        Console.WriteLine(x == 5); // X es igual que 5

        int ageA = 10;
        int ageB = 21;

        if (ageA < ageB)
        {
            Console.WriteLine("La edad A es menor que la edad B");
        }
        else
        {
            Console.WriteLine("La edad A es mayor que la edad B");
        }
    }

    // Condicionales
    static void condicionales()
    {   

        // Flujo de condicional
        // bool condition = true;
        int condition = 1;

        if (condition.GetType() == typeof(bool))
        {
            Console.WriteLine("La variable condition es bool");
        }
        else if(condition.GetType() == typeof(int))
        {
            Console.WriteLine("La variable contion es int");
        }
        else
        {
            Console.WriteLine("La variable condition no es ni bool ni int");
        }

        // Condicional corto
        // variable = (condition) ? expressionTrue :  expressionFalse;
        int time = 19;
        string result = (time < 18) ? "Good day." : "Good evening.";
            // La variable resultado tomara x valor dependiendo de la oepración logica de (time < 18)
                // Si es false, osea que time es mayor que 18 tomara result un valor igual Good Evening
                // Si es true, osea que time es menor a 18 tomara result un valor igual a Good day
        Console.WriteLine(result);

    }

    static void swictMethod()
    {        
        int day = 4;
        switch (day) // Variable que tomara en cuenta
        {
            case 1:
             Console.WriteLine("Lunes");
             break; // Romper codigo al seleccionar
            case 2:
             Console.WriteLine("Martes");
             break;
            case 3:
             Console.WriteLine("Miercoles");
             break;
            case 4:
             Console.WriteLine("Jueves");
             break;
            case 5:
             Console.WriteLine("Viernes");
             break;
            default:
                Console.WriteLine("Ningun case corresponde con algun valor de la variable day");
                break;
        }

    }

    static void mientrasTanto() {
        bool condicional = true;

        while (condicional) {
            Console.WriteLine("Condicional siendo verdadera");
            condicional = false;
            Console.WriteLine("Condicional ahora es falsa");
        }

        int i = 0;
        while (i < 5) {
            i++;
            Console.WriteLine($"Condicional de {i} < 5");
            
        }    

    }

    static void paraCada() {

        // Ciclo for
        /* for (int i = 0; i < 5; i++) { // Mientras i sea menor a 5 ejecuta bloque de codigo
            Console.WriteLine(i); // Bloque de codigo
        } */

        // Outer loop
        for (int i = 1; i <= 2; ++i) 
        {
        Console.WriteLine("Outer: " + i);  // Executes 2 times

        // Inner loop
        for (int j = 1; j <= 3; j++) 
        {
            Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
        }
        }
    }

    static void paraCadaUno() 
    {
        string[] carros = {"Volve", "BMW", "Ford", "Mazda"};
        foreach (string carro in carros){
            Console.WriteLine(carro);
        }
    }

    static void romperCiclo() 
    {   
        for(int i = 0; i < 10; i++)
        {               
            if (i == 4) 
            {
                Console.WriteLine("Rompiendo el ciclo");
                break;  
            }

            Console.WriteLine(i);
        }
    }

    static void continuaCiclo()
    {
        for(int i = 0; i < 10; i++)
        {
            if(i == 4){
                continue; // Saltar el bloque de codigo que se ejecuta en el ciclo
            }
            Console.WriteLine(i);
        }
    }
}