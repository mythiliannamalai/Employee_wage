﻿Console.WriteLine("Welcome to employee wage computation");
int present = 1;
int fulltime = 1;
int Emp_per_rate = 20;
int emphr = 0;
int emphrs = 0;
int empwage = 0;
int total_wday = 20;
int month_pay = 0;
int empattc=0;
while (empattc != 20 && emphrs != 100)
{
    Random random = new Random();
    Random random1 = new Random();
    int Employeestates = random.Next(0, 2);
    int Employeetime = random1.Next(0, 2);
    if (Employeestates == present)
    {
        present = 1;
    }
    else
    {
        present = 0;

    }

    switch (present)
    {
        case 1:
            empattc++;
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
            break;
        default:
            Console.WriteLine("the Employee is absent");

            emphr = 0;
            break;
    }

    emphrs = (emphr + emphrs);
}
empwage = (Emp_per_rate * emphr);
Console.WriteLine("Daily wage" + empwage);
month_pay = (total_wday * empwage);
Console.WriteLine("monthly wage : " + month_pay);
Console.WriteLine("working hours :" + emphrs);