namespace Emp_Wge
{
    class Program
    {
        public int PRESENT = 1;
        public int FULL_TIME = 1;
        public int EMP_RATE_PER_HR = 20;
        public int EMP_PER_HR = 0;
        public int TOTAL_WORK_HR = 0;
        public int ONE_DAY_EMP_WAGE = 0;
        public int TOTAL_WORK_DAYS = 20;
        public int MOTHLY_EMP_WAGE = 0;
        public int EMP_ATTENDANCE_COUNT = 0;
        public int ATTENDANCE;
        public int WORK_TYPE;
        public void Calculation()
        {
            Console.WriteLine("Welcome to employee wage computation");

            while (EMP_ATTENDANCE_COUNT != 20 && TOTAL_WORK_HR <= 100)
            {
                Random random = new Random();
                Random random1 = new Random();
                ATTENDANCE = random.Next(0, 2);
                WORK_TYPE = random1.Next(0, 2);
                if (ATTENDANCE == PRESENT)
                {
                    PRESENT = 1;
                }
                else
                {
                    PRESENT = 0;
                }
                switch (PRESENT)
                {
                    case 1:
                        if (WORK_TYPE == FULL_TIME)
                        {
                            Console.WriteLine("the Employee is present");
                            EMP_PER_HR = 8;
                        }
                        else
                        {
                            Console.WriteLine("the Employee is partimer");
                            EMP_PER_HR = 4;
                        }
                        EMP_ATTENDANCE_COUNT++;
                        break;
                    default:
                        Console.WriteLine("the Employee is absent");
                        EMP_PER_HR = 0;
                        break;
                }
                TOTAL_WORK_HR = (EMP_PER_HR + TOTAL_WORK_HR);
            }
            ONE_DAY_EMP_WAGE = (EMP_RATE_PER_HR * EMP_PER_HR);
            Console.WriteLine("Daily Wage" + ONE_DAY_EMP_WAGE);
            MOTHLY_EMP_WAGE = (TOTAL_WORK_DAYS * EMP_ATTENDANCE_COUNT);
            Console.WriteLine("Monthly Wage : " + MOTHLY_EMP_WAGE);
            Console.WriteLine("Total Working Hours :" + TOTAL_WORK_HR);
            Console.WriteLine("Employee Attendance Count :" + EMP_ATTENDANCE_COUNT);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Calculation();
        }
    }
}