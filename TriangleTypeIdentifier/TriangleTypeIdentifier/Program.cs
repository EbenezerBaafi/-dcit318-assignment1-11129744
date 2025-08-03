// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------------------");
Console.WriteLine("---Tiangle Type Identifier----!");


//Prompt the user to enter 3 sides of a triangle
Console.Write("Enter sideA: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sideB: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sideC: ");
int sideC = Convert.ToInt32(Console.ReadLine());

// Validate triangle inequality theorem

if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
{
    if (sideA == sideB && sideB == sideC)
        Console.WriteLine("The triangle is an equilateral triangle.");
    else if (sideA == sideB || sideB == sideC || sideA == sideC)
        Console.WriteLine("It is an Isosceles triangle.");
    else
    Console.WriteLine("It is a Scalene triangle.");
}
else
{
    Console.WriteLine("Error: Try agian, the sides entered cannot form a triangle");
}