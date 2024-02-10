using System.Text;

class Prograsm
{
    static void Main()
    {

        ejercicioMatriz1();

    }

    // Ejercio Matriz identificar pedidos con B
    static void ejercicioMatriz1() {
        // Declarar matriz
        string[] arrayPedidos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
        // Recorrer array
        foreach (string pedido in arrayPedidos)
        {
            if (pedido.StartsWith("B")) {
                Console.WriteLine(pedido);
            }
        }
    }

    // Sumar valor en foreach
    static void sumArray() {
        // Declaración de matriz
        int[] nums = {100, 200, 300};
        // Declaración de la variable para realizar suma
        int sum = 0;
        // Declaración de la variable para saber el num de iteraciones del foreach
        int bin = 0;
        // Recorrido de la matriz
        foreach (int num in nums) {
            sum += num;
            bin++;
            Console.WriteLine($"Elemento {bin} = {num} (Sum total: {sum})");
        }
        // Resultado de la sum
        Console.WriteLine($"\nLa suma de los elementos del array sumArray es {sum}");
    }

    // Recorrer array
    static void intArray()
    {
        // Declaración de matriz
        int[] nums = {21, 2, 20};
        // Recorrido de la matriz
        foreach (int num in nums) {
            Console.WriteLine(num);
        }
    }

    // Recorrer array
    static void RecorrerArray() 
    {
        // Declaración de matriz
        string[] arrayNames = {"Juanes", "Milan", "Niyi"};
        // Recorrer arrary e imprimir por consola
        foreach (string name in arrayNames)
        {
            Console.WriteLine(name);
        }

    }

    // Metodo de Matriz
    static void Matriz() 
    {
        // Declaración de matriz
        string[] frauduletOrderIDs = new string[3];
        
        // Asignación de valores a una matriz
        frauduletOrderIDs[0] = "A123";
        frauduletOrderIDs[1] = "B456";
        frauduletOrderIDs[2] = "C789";
        
        // Recuperar valores de la matriz
        Console.WriteLine($"Indice 0 de la matriz frauduletOrderIds es {frauduletOrderIDs[0]}");
        Console.WriteLine($"Indice 1 de la matriz frauduletOrderIds es {frauduletOrderIDs[1]}");
        Console.WriteLine($"Indice 2 de la matriz frauduletOrderIds es {frauduletOrderIDs[2]}");
        
        // Remplazar valor en algun indice
        frauduletOrderIDs[0] = "F000";
        Console.WriteLine($"\nReasignando el valor del indice 0 a {frauduletOrderIDs[0]}");

        // Declaración Mattriz con valores ya asignados
        string[] frauduletOrderIDs2 = {"A123", "B456", "C789"};
        Console.WriteLine($"\nIndice 0 de la matriz frauduletOrderIds es {frauduletOrderIDs2[0]}");
        Console.WriteLine($"Indice 1 de la matriz frauduletOrderIds es {frauduletOrderIDs2[1]}");
        Console.WriteLine($"Indice 2 de la matriz frauduletOrderIds es {frauduletOrderIDs2[2]}");

        // Conocer cantridad de elementos 
        Console.WriteLine($"\nThere are {frauduletOrderIDs.Length} fraudulent arders to process");
    }

    // Metodo de subscription
    static void subscription() 
    {
        Random random = new Random();
        int dayUntilExpiration = random.Next(0, 12);
        int discountPercentage = 0;


        if (dayUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired");
        }
        else if (dayUntilExpiration == 1)
        {
            discountPercentage += 20;
            Console.WriteLine($"Your subcription expires within a day! \nRenew now and save {discountPercentage}%!" );
        }
        else if (dayUntilExpiration <= 5)
        {
            discountPercentage += 10;
            Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days. \nRenow now and save {discountPercentage}%");
        }
        else if (dayUntilExpiration <= 10 )
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
    }
}   