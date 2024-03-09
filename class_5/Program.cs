//Ejercicios en clase

//ejercico 1
int numero;
int mayor = int.MinValue; 
int menor = int.MaxValue; 
Console.WriteLine("Ingrese valores positivos. Ingrese 0 para finalizar.");
do
{
    Console.Write("Ingrese un número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero != 0)
    {
      
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
} while (numero != 0);

Console.WriteLine("El mayor número ingresado es: " + mayor);
Console.WriteLine("El menor número ingresado es: " + menor);
Console.ReadLine();