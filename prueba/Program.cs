Random coin = new Random();
int tirada = coin.Next(0, 2);
Console.WriteLine((tirada==0) ? "Cara" : "Cruz");
Console.ReadKey();
