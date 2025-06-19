namespace MVCSalary.Services
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public double Calculate(string name, int age, int totalHours)
        {
            double salaryPerhour = 0;

            if (age<30)
            {
                salaryPerhour = 100;
            }
            else if (age >=30 && age <=50)
            {
                salaryPerhour = 120;
                
            }
            else
            {
                salaryPerhour = 130;

                
            }
            if (name == "Nelly")
            {
                salaryPerhour = salaryPerhour * 1.1;
            }
            return salaryPerhour * totalHours;

        }

    }
}
