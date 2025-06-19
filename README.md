# MVCSalary

 C# MVC service that calculates salary based on age, hours worked, and employee name.  
This project is primarily intended for learning and testing business logic using **unit tests**.

## Features

- Calculates hourly salary based on age:
  - Under 30: 100 kr/h  
  - 30 to 50: 120 kr/h  
  - Over 50: 130 kr/h  
- Applies a 10% salary bonus if the employee's name is **Nelly**
- Total salary = hourly rate × total hours worked

## Example

For an employee named "Nelly", age 25, who worked 10 hours:  
Salary = (100 × 1.1) × 10 = **1100 kr**

## Technologies

- .NET / C#
- MSTest for unit testing
- ASP.NET Core MVC architecture

## How to Run Tests

1. Open the solution in **Visual Studio**
2. Build the project
3. Run tests using `Test > Run All Tests` or press `Ctrl + R, A`

