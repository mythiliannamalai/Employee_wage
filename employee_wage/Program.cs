Console.WriteLine("Welcome to employee wage computation");
int present = 1;
int fulltime = 1;
int Emp_per_rate = 20;
int emphr = 0;
int empwage = 0;
Random random = new Random();
Random random1 = new Random();
int Employeestates = random.Next(0, 2);
int Employeetime = random1.Next(0, 2);
if (Employeestates == present)
{
    if (Employeetime == fulltime)
    {
        Console.WriteLine("the Employee is present");
        emphr = 8;
    }
    else
    {
        Console.WriteLine("the Employee is partimer");
        emphr = 4;
    }
}
else
{
    Console.WriteLine("the Employee is absent");

    emphr = 0;
}
empwage = (Emp_per_rate * emphr);
Console.WriteLine("Daily wage" + empwage);