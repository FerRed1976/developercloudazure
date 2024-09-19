/* string first = "5";
string second = "7";
int resultado;
Console.WriteLine(int.TryParse(second, out resultado));
int sum = int.Parse(first) + resultado;
Console.WriteLine(sum); */


/* string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); */

/* string[] values = { "12.3", "45", "ABC", "11", "DEF" };
var Total = "";
var mensaje = 0.0;
var resultado = 0.0;

foreach (var value in values)
{
    if (double.TryParse(value, out resultado))
    {Total += resultado;}
    else
    {mensaje += value;}
}
Console.clear();
Console.WriteLine("Mensaje" + mensaje);
Console.WriteLine("Total" + Total); */

/* string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
 */
/* Message: ABCDEF
Total: 68.3 */

/* int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;
// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); */

/* int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); */
/* 
string[] pallets = { "1", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Clear(pallets,0,2);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Array.Reverse(pallets);
Console.WriteLine(pallets[0]);
 */
using System.Reflection;
using System.Runtime.CompilerServices;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] resultado = pangram.Split(" ");
//string [] reverse =new string [resultado.Length];

string final = string.Empty;
for (int i = 0; i < resultado.Length; i++);
 {
    final += string.Join ("", resultado[i].ToCharArray().Reverse())+"";

 }
pangram.Reverse();
