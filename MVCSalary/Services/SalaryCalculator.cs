namespace MVCSalary.Services
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public decimal Calculate(string name, decimal age, decimal totalHours)
        {
            decimal salaryPerHour = 0;

            if (age < 30)
                salaryPerHour = 100;
            else if (age <= 50)
                salaryPerHour = 120;
            else
                salaryPerHour = 130;

            if (name.Equals("Nelly", StringComparison.OrdinalIgnoreCase))
                salaryPerHour *= 1.1m;

            return salaryPerHour * totalHours;
        }



    }
}
