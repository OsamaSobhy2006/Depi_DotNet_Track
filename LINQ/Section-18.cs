#region Q119
//var result119 = Repository.Employees.GroupBy(e => e.DepartmentId);
//Print(result119);
#endregion

#region Q120
//var result120 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, EmployeeCount = g.Count() });
//Print(result120);
#endregion

#region Q121
//var result121 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, EmployeeCount = g.Count()});
//Print(result121);
#endregion

#region Q122
//var result122 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, TotalSalary = g.Sum(e => e.Salary) });
//Print(result122);
#endregion

#region Q123
//var result123 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, AverageSalary = g.Average(e => e.Salary) });
//Print(result123);
#endregion

#region Q124
//var result124 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, HighestSalary = g.Max(e => e.Salary) });
//Print(result124);
#endregion

#region Q125
//var result125 = Repository.Employees.GroupBy(e => e.DepartmentId)
//    .Select(g => new { DepartmentId = g.Key, LowestSalary = g.Min(e => e.Salary) });
//Print(result125);
#endregion