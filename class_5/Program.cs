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


Console.WriteLine("Piensa en un número");
Console.WriteLine("Sigue las instrucciones y te adivinaré el número que has pensado.");
Console.Write("Escribe un número: ");
Console.WriteLine("Multiplica tu numero por 2");
Console.WriteLine("Sumale 8 al resultado");
Console.WriteLine("Multiplica por 5 el nuevo resultado");
Console.Write("Dime el resultado final: ");
int resultadoFinal = int.Parse(Console.ReadLine());
string resultadoString = resultadoFinal.ToString();
resultadoString = resultadoString.Substring(0, resultadoString.Length - 1);
resultadoFinal = int.Parse(resultadoString) - 4;
Console.WriteLine($"El número que pensaste es: {resultadoFinal} jejeje");

Console.WriteLine("Ingrese una frase:");
string frase = Console.ReadLine();
int contadorPalabras = 0;
int contadorVocales = 0;
int indice = 0;

while (indice < frase.Length)
{
    while (indice < frase.Length && frase[indice] == ' ')
    {
        indice++;
    }
    if (indice == frase.Length)
    {
        break;
    }

    while (indice < frase.Length && frase[indice] != ' ')
    {
        contadorPalabras++;
        char caracter = char.ToLower(frase[indice]);
        if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
        {
            contadorVocales++;
        }
        indice++;
    }
}
Console.WriteLine($"Número de palabras en la frase: {contadorPalabras}");
Console.WriteLine($"Número de vocales en la frase: {contadorVocales}");