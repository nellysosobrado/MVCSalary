namespace MVCSalary.Services
{
    public interface ISalaryCalculator
    {
        decimal Calculate(
            string name,
            decimal age,
            decimal totalHours
            
            );
    }
}
