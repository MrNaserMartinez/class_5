//Ejercicios

static void suma()
{
    // ejercicio 1
    int n1, n2, resultado = 0;
    Console.WriteLine("Ing. 1");
    n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ing. 1");
    n2 = Convert.ToInt32(Console.ReadLine());
    resultado = n1 + n2;
}

static string datos()
{
    // ejercicio 2
    Console.WriteLine("Ingrese nombre: ");
    String nombre = Console.ReadLine();
    Console.WriteLine($"saludos {nombre}");
    return nombre;
}

static void calculoEdad()
{
    //ejercicio 3
    Console.WriteLine("Ingrese su edad:");
    int anionacimiento = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - anionacimiento;
    Console.WriteLine($"Su edad es: {edad}");
}






//calculoEdad();
//datos();   
//suma(); 


static int sumatoria(int num1, int num2, int num3)
{
    int resultado = 0;
    resultado = num1 + num2 + num3;
    return resultado;
}

string nombre = datos();
int promedio = sumatoria(20, 25, 40) / 3;
Console.WriteLine($"promedio={promedio}");