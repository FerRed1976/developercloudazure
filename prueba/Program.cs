

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (producto)
{
  case 02:
  type = "Sweat shirt";
  break ;
  case 03:
  type = "T-Shirt";
  break;
   
  case "BL":
  color = "Black";
  break;
  case "MN":
  color = "Maroon"
  break;
  case"W":
  color = "White"
  break;

  case "s":
  size = "Small";
  break;
  case "M":
  size = "Medium";
  break;
  case "L":
  size = "Large";
}
Console.WriteLine($"Product: {size} {color} {type}");