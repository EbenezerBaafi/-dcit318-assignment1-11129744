Console.WriteLine("------------------------");
Console.WriteLine("----Grade Calculator----");

Console.Write("Enter a number between 0 and 100: ");
int score = Convert.ToInt32(Console.ReadLine());

if (score > 90 && score <= 100)
{
    Console.WriteLine($"Score: {score}  --- Grade: A");
}
else if (score >= 80 && score < 90)
{
    Console.WriteLine($"Score: {score}  --- Grade: B");
}
else if (score >= 70 && score < 80)
{
    Console.WriteLine($"Score: {score}  --- Grade: C");
}
else if (score >= 60 && score < 70)
{
    Console.WriteLine($"Score: {score}  --- Grade: D");
}
else
{
    Console.WriteLine($"Score: {score}  --- Grade: F");
}