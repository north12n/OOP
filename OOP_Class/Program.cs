
using Administration;

var employees = Employees.GenerateEmployees(5);

foreach (var employee in employees)
{
    employee.Display();
}