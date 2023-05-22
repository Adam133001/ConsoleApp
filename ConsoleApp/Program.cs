using challengeapp;


Employee employee1 = new Employee("Adam", "Kowalski", 21);
Employee employee2 = new Employee("John", "Prusik", 27);
Employee employee3 = new Employee("Beata", "Kunikowska", 23);


employee1.AddGrade(2);
employee1.AddGrade(9);
employee1.AddGrade(7);
employee1.AddGrade(9);
employee1.AddGrade(9);

employee2.AddGrade(9);
employee2.AddGrade(6);
employee2.AddGrade(1);
employee2.AddGrade(9);
employee2.AddGrade(7);
employee2.AddGrade(8);

employee3.AddGrade(9);
employee3.AddGrade(8);
employee3.AddGrade(8);
employee3.AddGrade(9);
employee3.AddGrade(9);

//int age1 = 10;
//int age2 = 3;


List<Employee> employees = new List<Employee>() { employee1, employee2, employee3 };

double highestGrade = -1;
Employee employeeWithHighestGrade = null;
foreach (var employee in employees)
{
    if (employee1.Result > highestGrade)
    {
        employeeWithHighestGrade = employee1;
        highestGrade = employee1.Result;
    }
    else if (employee2.Result > highestGrade)
    {
        employeeWithHighestGrade = employee2;
        highestGrade = employee2.Result;
    }
    else if (employee3.Result > highestGrade)
    {
        employeeWithHighestGrade = employee3;
        highestGrade = employee3.Result;
    }
}
Console.WriteLine("Employee score are:");
Console.WriteLine($"Adam - {employee1.Result}");
Console.WriteLine($"John - {employee2.Result}");
Console.WriteLine($"Beata - {employee3.Result}");
Console.WriteLine("________________________________");
Console.WriteLine("Employee with the highest score is:");
Console.WriteLine($"{employeeWithHighestGrade.FirstName} {employeeWithHighestGrade.LastName}");
Console.WriteLine($"{employeeWithHighestGrade.Age} years old");
Console.WriteLine($"grade: {employeeWithHighestGrade.Result}");
