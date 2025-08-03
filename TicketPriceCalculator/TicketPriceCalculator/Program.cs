// See https://aka.ms/new-console-template for more information
Console.WriteLine("------------------------------");
Console.WriteLine("----Ticket Price Calculator---");

float ticketPrice = 10.00F;

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age <= 12 || age >=65)
    Console.WriteLine($"You are {age} years old and the price is GHS7.00");

else Console.WriteLine($"You are {age} years old and the price is GHS{ticketPrice}.");