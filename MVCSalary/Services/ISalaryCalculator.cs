namespace MVCSalary.Services
{
    public interface ISalaryCalculator
    {
        double Calculate(
            string name,
            int age,
            int totalHours
            
            );
    }
}
