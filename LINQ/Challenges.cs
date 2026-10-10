#region Challenge 1
//var employees = Repository.Employees
//    .Where(e => e.IsActive && e.Age > 30 && e.Salary > 15000)
//    .OrderByDescending(e => e.Salary)
//    .Select(e => e.Name);
//Print(employees);
#endregion

#region Challenge 2
//var employees = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new
//    {
//        DepartmentId = g.Key,
//        TotalSalary = g.Sum(e => e.Salary),
//        AverageSalary = g.Average(e => e.Salary),
//        EmployeeCount = g.Count()
//    });
//Print(employees);
#endregion

#region Challenge 3
//var result = Repository.Departments.GroupJoin(
//    Repository.Employees.Where(e => e.IsActive),
//    d => d.Id,
//    e => e.DepartmentId,
//    (d, employees) => new
//    {
//        DepartmentName = d.Name,
//        ActiveEmployeesCount = employees.Count(),
//        AverageSalary = employees.Any() ? employees.Average(e => e.Salary) : 0
//    });
//Print(result);
#endregion

#region Challenge 4
//var result = Repository.Departments.Join(
//    Repository.Employees,
//    d => d.ManagerId,
//    e => e.Id,
//    (d, e) => new
//    {
//        DepartmentName = d.Name,
//        ManagerName = e.Name,
//        ManagerSalary = e.Salary
//    });
//Print(result);
#endregion

#region Challenge 5
//var employees = Repository.Employees
//    .Where(e => e.IsActive && e.Skills.Contains("C#"))
//    .OrderBy(e => e.HireDate);
//Print(employees);
#endregion

#region Challenge 6
//var result = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new {DepartmentId = g.Key, EmployeeCount = g.Count()})
//    .Join(Repository.Departments,
//    g => g.DepartmentId,
//    d => d.Id,
//    (g, d) => new
//    {
//        DepartmentName = d.Name,
//        g.EmployeeCount
//    })
//    .MaxBy(d => d.EmployeeCount);
//Console.WriteLine($"{result.DepartmentName} - {result.EmployeeCount}");
#endregion

#region Challenge 7
//var result = Repository.Employees
//.GroupBy(e => e.DepartmentId)
//.Select(g => new { DepartmentId = g.Key, TotalPayroll = g.Sum(e => e.Salary) })
//.Join(Repository.Departments,
//    g => g.DepartmentId,
//    d => d.Id,
//    (g, d) => new { DepartmentName = d.Name, g.TotalPayroll })
//.MaxBy(d => d.TotalPayroll);
//Console.WriteLine($"{result.DepartmentName} - {result.TotalPayroll}");
#endregion

#region Challenge 8
//var result = Repository.Employees.Where(e => !e.Skills.Any(s => s.Contains("SQL")));
//Print(result);
#endregion

#region Challenge 9
//var result = Repository.Departments
//    .GroupJoin(Repository.Employees,
//        d => d.Id,
//        e => e.DepartmentId,
//        (d, employees) => new
//        {
//            DepartmentName = d.Name,
//            EmployeeCount = employees.Count()
//        });
//Print(result);
#endregion

#region Final Challenge
//var departmentReport = Repository.Departments
//    .GroupJoin(Repository.Employees,
//        d => d.Id,
//        e => e.DepartmentId,
//        (d, employees) => new
//        {
//            Department = d,
//            Employees = employees.ToList()
//        })
//    .Select(x => new
//    {
//        DepartmentName = x.Department.Name,
//        ManagerName = Repository.Employees
//            .FirstOrDefault(e => e.Id == x.Department.ManagerId)?.Name ?? "NoBody",
//        EmployeeCount = x.Employees.Count,
//        ActiveCount = x.Employees.Count(e => e.IsActive),
//        TotalSalaries = x.Employees.Sum(e => e.Salary),
//        AverageSalary = x.Employees.Any()
//            ? x.Employees.Average(e => e.Salary) : 0,
//        HighestSalary = x.Employees.Any()
//            ? x.Employees.Max(e => e.Salary) : 0
//    });
//foreach (var department in departmentReport)
//{
//    Console.WriteLine($"Department: {department.DepartmentName}");
//    Console.WriteLine($"Manager: {department.ManagerName}");
//    Console.WriteLine($"Employees: {department.EmployeeCount} (Active: {department.ActiveCount})");
//    Console.WriteLine($"Total Salaries: {department.TotalSalaries:N2}");
//    Console.WriteLine($"Average Salary: {department.AverageSalary:N2}");
//    Console.WriteLine($"Highest Salary: {department.HighestSalary:N2}");
//    Console.WriteLine("--------------------------------------------");
//}
#endregion