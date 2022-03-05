Console.WriteLine("Welcome to employee wage computation");
int present = 1;
Random random = new Random();
int Employeestates = random.Next(0, 2);
if (Employeestates == present)
{
    Console.WriteLine("the Employee is present");
}
else
{
    Console.WriteLine("the Employee is absent");
}