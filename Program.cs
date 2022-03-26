using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Emp_Wge
{
    class Company
    {
        ArrayList companyDetail = new ArrayList();
        Dictionary<string, ArrayList> companie = new Dictionary<string, ArrayList>();
        public int PRESENT = 1;
        public int FULL_TIME = 1;
        public int FULLTIME_EMP_WORK_HR;
        public int PARTTIME_EMP_WORK_HR;
        public int EMP_WAGE_PER_HR = 20;
        public int EMP_WORKING_HR = 0;
        public int TOTAL_WORK_HR = 0;
        public int ONE_DAY_EMP_WAGE = 0;
        public int TOTAL_WORK_DAYS = 20;
        public int MOTHLY_EMP_WAGE = 0;
        public int EMP_ATTENDANCE_COUNT = 0;
        public int ATTENDANCE;
        public string COMPANY_NAME;
        public void AddDetail(string COMPANY_NAME, int EMP_WAGE_PER_HR, int FULLTIME_EMP_WORK_HR, int PARTTIME_EMP_WORK_HR, int TOTAL_WORK_HR, int TOTAL_WORK_DAYS)
        {
            this.COMPANY_NAME = COMPANY_NAME;
            this.EMP_WAGE_PER_HR = EMP_WAGE_PER_HR;
            this.FULLTIME_EMP_WORK_HR = FULLTIME_EMP_WORK_HR;
            this.PARTTIME_EMP_WORK_HR = PARTTIME_EMP_WORK_HR;
            this.TOTAL_WORK_HR = TOTAL_WORK_HR;
            this.TOTAL_WORK_DAYS = TOTAL_WORK_DAYS;
            companyDetail.Add(COMPANY_NAME);
            companyDetail.Add(EMP_WAGE_PER_HR);
            companyDetail.Add(FULLTIME_EMP_WORK_HR);
            companyDetail.Add(PARTTIME_EMP_WORK_HR);
            companyDetail.Add(TOTAL_WORK_HR);
            companyDetail.Add(TOTAL_WORK_DAYS);
            companie.Add(COMPANY_NAME, companyDetail);
        }
        public void Calculation(string CAMPANY_NAME)
        {
            while (EMP_ATTENDANCE_COUNT != 20 && TOTAL_WORK_HR <= 100)
            {
                Random random = new Random();
                ATTENDANCE = random.Next(0, 2);
                switch (ATTENDANCE)
                {
                    case 1:
                        EMP_WORKING_HR = FULLTIME_EMP_WORK_HR;
                        EMP_ATTENDANCE_COUNT++;
                        break;
                    case 2:
                        EMP_WORKING_HR = PARTTIME_EMP_WORK_HR;
                        EMP_ATTENDANCE_COUNT++;
                        break;
                    case 0:
                        EMP_WORKING_HR = 0;
                        break;
                }
            }
            Console.WriteLine("\nCompany name :" + COMPANY_NAME);
            ONE_DAY_EMP_WAGE = (EMP_WAGE_PER_HR * EMP_WORKING_HR);
            Console.WriteLine("Daily Wage :" + ONE_DAY_EMP_WAGE);
            MOTHLY_EMP_WAGE = (ONE_DAY_EMP_WAGE * EMP_ATTENDANCE_COUNT);
            Console.WriteLine("Monthly Wage : " + MOTHLY_EMP_WAGE);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            Company program = new Company();
            program.AddDetail("tata", 20, 8, 4, 100, 20);
            program.Calculation("tata");
            program.AddDetail("mahindra", 30, 8, 4, 100, 20);
            program.Calculation("mahindra");
        }
    }
}