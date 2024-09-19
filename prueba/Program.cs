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

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

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

/* Message: ABCDEF
Total: 68.3 */