// See https://aka.ms/new-console-template for more information
//Console.Write("Congratulation");
// Console.Write(" ");
//Console.Write("Estoy aqui");

//RANDOM
//var dados = new Random ();
//var roll = dados.Next(1,7);
//Console.WriteLine (roll);

//Prueba de Evaluacion
//int firstValue = 500;
//int secondValue = 600;
//int largerValue;
//largerValue = Math.Max(firstValue,secondValue);
//Console.WriteLine(largerValue);

//If Else

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


//Ejercicio Reglas de negocio
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
//    Console.WriteLine("Numero de diaspara expirar: " + daysUntilExpiration);
if (daysUntilExpiration > 5)
{ 
    Console.WriteLine("Tu suscripcion est'a a punto de expirar. Renueva ahora!");
}
else if (daysUntilExpiration <= 10 && n>1);
{
    Console.WriteLine("Your subscription expires in _ days.Renew now and save 10%!");
}
