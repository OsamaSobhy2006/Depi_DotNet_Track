#region Q126
//var result126 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, ActiveEmployeeCount = g.Count(e => e.IsActive) });
//Print(result126);
#endregion

#region Q127
//var result127 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, TotalActiveSalary = g.Where(e => e.IsActive).Sum(e => e.Salary) });
//Print(result127);
#endregion

#region Q128
//var result128 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, AverageSalary = g.Where(e => e.Salary > 10000).Average(e => e.Salary) });
//Print(result128);
#endregion

#region Q129
//var result129 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, EmployeeCount = g.Count(e => e.HireDate.Year > 2020) });
//Print(result129);
#endregion