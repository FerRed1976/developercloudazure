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
/* using System.Reflection;
using System.Runtime.CompilerServices;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] resultado = pangram.Split(" "); */
//string [] reverse =new string [resultado.Length];
/* 
string final = string.Empty;
for (int i = 0; i < resultado.Length; i++);
 {
    final += string.Join ("", resultado[i].ToCharArray().Reverse())+"";

 }
pangram.Reverse();
 */
/* 
using System.Globalization;

 decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
 */
/*  decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P}"); */

/* string input = "Pad this";
 Console.WriteLine(input.PadRight(18,'-')); */

/* 
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20); */

// Console.WriteLine(comparisonMessage);
/* 
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition); */

/* string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}"); */

/* string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 25);
Console.WriteLine(updatedData); */



/* const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";


// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output); */
/* 
using System.Net.Mail;

Console.Clear();
Console.WriteLine (DateTime.Now.ToString ("dd-MM-yy HH:mm:ss.fff"));
Console.WriteLine (DateTime.UtcNow.ToLongTimeString());
Console.WriteLine (DateTime.Today.ToLongDateString());

 */
/* 
 Console.Clear ();
 var hoy = DateTime.UtcNow;
 Console.WriteLine (hoy.AddMonths(1)); */



 Console.Clear();
 var fecha = new DateTime (2024,05,31);
Console.WriteLine (fecha.AddMonths(1).Ticks);

